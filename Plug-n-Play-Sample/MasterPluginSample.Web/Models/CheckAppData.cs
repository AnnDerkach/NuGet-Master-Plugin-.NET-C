﻿namespace Sequencing.MasterPluginSample.Web.Models
{
    /// <summary>
    /// CheckApp page model
    /// </summary>
    public class CheckAppData : CommonData
    {
        public string selectedId { get; set; }
        public string melanomaRisk { get; set; }
        public string vitD { get; set; }
    }
}