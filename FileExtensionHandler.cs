﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpSearch
{
    class FileExtensionHandler
    {
        static string[] archiveFormats = {
            ".7z",
            ".s7z",
            ".ace",
            ".afa",
            ".alz",
            ".apk",
            ".arc",
            ".arj",
            ".b1",
            ".b6z",
            ".ba",
            ".bh",
            ".cab",
            ".car",
            ".cfs",
            ".cpt",
            ".dar",
            ".dd",
            ".dgc",
            ".dmg",
            ".ear",
            ".gca",
            ".ha",
            ".hki",
            ".ice",
            ".jar",
            ".kgb",
            ".lzh",
            ".lha",
            ".lzx",
            ".pak",
            ".partimg",
            ".paq6",
            ".paq7",
            ".paq8",
            ".pea",
            ".pim",
            ".pit",
            ".qda",
            ".rar",
            ".rk",
            ".sda",
            ".sea",
            ".sen",
            ".sfx",
            ".shk",
            ".sit",
            ".sitx",
            ".sqx",
            ".tar.gz",
            ".tgz",
            ".tar.Z",
            ".tar.bz2",
            ".tbz2",
            ".tar.lzma",
            ".tlz.",
            ".tar.xz",
            ".txz",
            ".uc",
            ".uc0",
            ".uc2",
            ".ucn",
            ".ur2",
            ".ue2",
            ".uca",
            ".uha",
            ".war",
            ".wim",
            ".xar",
            ".xp3",
            ".yz1",
            ".zip",
            ".zipx",
            ".zoo",
            ".zpaq",
            ".zz"
        };

        static string[] imageFormats = {
            ".AI",
            ".ANI",
            ".ANIM",
            ".APNG",
            ".ART",
            ".BMP",
            ".BPG",
            ".BSAVE",
            ".CAL",
            ".CDF",
            ".CDR",
            ".CGM",
            ".CIFF",
            ".CIN",
            ".CPC",
            ".CPT",
            ".CUR",
            ".DDS",
            ".DjVu",
            ".DNG",
            ".DPX",
            ".DXF",
            ".ECW",
            ".EMF",
            ".EP",
            ".EPS",
            ".EVA",
            ".Exif",
            ".EXR",
            ".FITS",
            ".FLIC",
            ".FLIF",
            ".FPX",
            ".Gerber",
            ".GIF",
            ".HDRi",
            ".HEVC",
            ".HVIF",
            ".ICER",
            ".ICNS",
            ".ICO",
            ".ICS",
            ".IGES",
            ".ILBM",
            ".IT",
            ".JBIG",
            ".JBIG2",
            ".JNG",
            ".JPG",
            ".JPEG",
            ".JPEG-HDR",
            ".JPEG-LS",
            ".KRA",
            ".Logluv",
            ".MIFF",
            ".MNG",
            ".NRRD",
            ".ORA",
            ".PAM",
            ".PBM",
            ".PCX",
            ".PDF",
            ".PGF",
            ".PGM",
            ".PGML",
            ".PICT",
            ".PICtor",
            ".PNG",
            ".PNM",
            ".PPM",
            ".PS",
            ".PSB",
            ".PSD",
            ".PSP",
            ".QTVR",
            ".RAS",
            ".RGBE",
            ".SGI",
            ".SVG",
            ".SWF",
            ".TGA",
            ".TIFF",
            ".UFO",
            ".UFP",
            ".VML",
            ".WBMP",
            ".WebP",
            ".WMF",
            ".XAML",
            ".Xar",
            ".XBM",
            ".XCF",
            ".XMP",
            ".XPM",
            ".XR",
            ".XT",
            ".XWD"
        };

        static string[] virtualImageFormats = {
            ".BIN",
            ".CUE",
            ".CSO",
            ".DAA",
            ".IMG",
            ".CCD",
            ".SUB",
            ".ISO",
            ".ISZ",
            ".MDF",
            ".MDS",
            ".MDX",
            ".NRG",
            ".UIF",
            ".DMG",
            ".FVD",
            ".IMG",
            ".ISO",
            ".NDIF",
            ".QCOW",
            ".UDIF",
            ".VDI",
            ".VHD",
            ".VMDK",
            ".WIM",
            ".ADF",
            ".ADZ",
            ".DC42",
            ".DART",
            ".DCF",
            ".DMS",
            ".IMG",
            ".IMA",
            ".IMZ",
            ".VFD"
        };

        static string[] executables =
        {
            ".exe",
            ".elf",
            ".dll"
        };

        public static bool HasCleanExtension(string path)
        {
            return !(
                EndsWithExtension(path, imageFormats) ||
                EndsWithExtension(path, archiveFormats) ||
                EndsWithExtension(path, virtualImageFormats));
        }

        public static bool EndsWithExtension(string path, string[] extensionList)
        {
            foreach(string ext in extensionList)
            {
                string lowerExt = ext.ToLower();
                string lowerPath = path.ToLower();
                if (lowerPath.EndsWith(lowerExt))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
