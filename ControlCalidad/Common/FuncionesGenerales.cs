using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Common
{
	public static class FuncionesGenerales
	{
		public static byte[] ConvertImageBite(Image _image)
		{
			byte[] _imgArr;
			using (MemoryStream ms = new MemoryStream())
			{
				_image.Save(ms, ImageFormat.Gif);
				_imgArr = ms.ToArray();
			}

			return _imgArr;
		}

	}
}
