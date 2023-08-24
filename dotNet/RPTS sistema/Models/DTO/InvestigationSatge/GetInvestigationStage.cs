﻿namespace RPTS_sistema.Models.DTO.InvestigationSatge
{
    public class GetInvestigationStage
    {

        public GetInvestigationStage(InvestigationStage stage)
        {
            Stage = stage.TimeStamp.ToString("yyyy-MM-dd") + ": " + stage.Stage;
        }
        /// <summary>
        /// grazinamas atiduodant tyrimo etapus i constuktoriu paduodant tyrimo etapu sarasa ir grazinant sumapinta 
        /// etapo data ir etapo aprasyma
        /// </summary>
        public string Stage { get; set; }
    }
}
    