using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DogStancer
{
    [XmlRoot("StepList")]
    public class StepList
    {
        [XmlElement("Step")]
        public List<Step> Steps { get; set; }
    }

    public class Step
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Desc")]
        public string Desc { get; set; }
    }


    [Serializable]
    [XmlRoot("SettingList", Namespace = "", IsNullable = false)]
    public class SettingList
    {
        //[XmlArray("Setting")]
        //[XmlArrayItem("Setting",typeof(Setting))]
        [XmlElement("Setting")]
        public List<Setting> Settings { get; set; }
    }


    [Serializable]
    public class Setting
    {
        public const string dImagesFolder = @"C:\Data\dogscats\dogs2";
        public const string dSortedImagesFolderBasePath = @"C:\Data\DogsSorted2";
        public const string dResizedImagesFolderBasePath = @"C:\Data\DogsSorted\DogsResized";

        public readonly string pathJumping = "jumping";
        public readonly string pathLaying = "laying";
        public readonly string pathNotADog = "notADog";
        public readonly string pathOther = "other";
        public readonly string pathRolling = "rolling";
        public readonly string pathSitting = "sitting";
        public readonly string pathStanding = "standing";

        [XmlElement("ImagesFolder")]
        public string ImagesFolder { get; set; }

        [XmlElement("SortedImagesFolderBasePath")]
        public string SortedImagesFolderBasePath { get; set; }

        [XmlElement("ResizedImagesFolderBasePath")]
        public string ResizedImagesFolderBasePath { get; set; }


        public void SetDefaults()
        {
            ImagesFolder = dImagesFolder;
            SortedImagesFolderBasePath = dSortedImagesFolderBasePath;
            ResizedImagesFolderBasePath = dResizedImagesFolderBasePath;
        }
    }
}