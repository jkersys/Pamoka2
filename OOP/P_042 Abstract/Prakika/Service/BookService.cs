﻿using Prakika.Enums;
using Prakika.Interface;
using Prakika.Models.Abstract;
using Prakika.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakika.Service
{
    public class BookService : IBookHtmlService
    {
        public Dictionary<BookType, List<Book>> Decode(string dataSeed)
        {
            Dictionary<BookType, List<Book>> res = new Dictionary<BookType, List<Book>>();
            res.Add(BookType.EBook, new List<Book>());
            res.Add(BookType.AudioBook, new List<Book>());
            res.Add(BookType.HardcoverBook, new List<Book>());
            res.Add(BookType.PaperBook, new List<Book>());

            string[] arr = dataSeed.Split("<tbody>");
            if (arr.Length < 2)
                return res;

            string[] rows = arr[1]
                .Replace("</tbody>", "")
                .Replace("</table>", "")
                .Replace("</table>", "")
                .Replace(Environment.NewLine, "")
                .Replace("</html>", "")
                .Replace("</td>", "")
                .Replace("</tr>", "")
                .Split("<tr>");

            foreach (var row in rows)
            {
                string[] cells = row.Split("<td>");
                if (cells.Length < 9)
                    continue;
                string genre = cells[1].Trim();
                string title = cells[2].Trim();
                string author = cells[3].Trim();
                int booksSold = GetBookSold(cells[4].Trim().Replace(".", ","));
                _ = int.TryParse(cells[5].Trim(), out int qtty);

                var ebookPrice = GetPrice(cells[6].Trim().Replace(".", ","));
                var audioPrice = GetPrice(cells[7].Trim().Replace(".", ","));
                var hardcoverPrice = GetPrice(cells[8].Trim().Replace(".", ","));
                var paperbackPrice = GetPrice(cells[9].Trim().Replace(".", ","));

                if (ebookPrice != null)
                {
                    res[BookType.EBook].Add(new EBook
                    {
                        Genre = genre,
                        Author = author,
                        Title = title,
                        BooksSold = booksSold,
                        Qtty = qtty,
                        Price = ebookPrice
                    });
                }
                if (audioPrice != null)
                {
                    res[BookType.AudioBook].Add(new AudioBook
                    {
                        Genre = genre,
                        Author = author,
                        Title = title,
                        BooksSold = booksSold,
                        Qtty = qtty,
                        Price = audioPrice
                    });
                }
                if (hardcoverPrice != null)
                {
                    res[BookType.HardcoverBook].Add(new HardcoverBook
                    {
                        Genre = genre,
                        Author = author,
                        Title = title,
                        BooksSold = booksSold,
                        Qtty = qtty,
                        Price = hardcoverPrice
                    });
                }
                if (paperbackPrice != null)
                {
                    res[BookType.PaperBook].Add(new PaperBook
                    {
                        Genre = genre,
                        Author = author,
                        Title = title,
                        BooksSold = booksSold,
                        Qtty = qtty,
                        Price = paperbackPrice
                    });
                }

            }


            return res;


        }

        private double? GetPrice(string v)
        {
            if (v.Contains("$"))
                return double.Parse(v.Replace("$", "")) * 0.95;
            else if (v.Contains("PLN"))
                return double.Parse(v.Replace(" PLN", "")) * 0.21;
            else if (v.Contains("EUR"))
                return double.Parse(v.Replace(" EUR", ""));
            else
                return null;
        }

        private int GetBookSold(string v)
        {
            if (v.Contains("million"))
                return (int)(double.Parse(v.Replace(" million", "")) * 1000000);
            if (v.Contains("billion"))
                return (int)(double.Parse(v.Replace(" billion", "")) * 1000000000);

            _ = int.TryParse(v, out int bs);
            return bs;
        }

        public string Encode(Dictionary<BookType, List<Book>> books)
        {
            List<BookHtml> res = new List<BookHtml>();

            foreach (var book in books)
            {
                BookHtml bookHtml = new BookHtml(); 


                res.Add(book);
            }
            return books.ToString();


          // return res.ToHtml();
        }
    }
}