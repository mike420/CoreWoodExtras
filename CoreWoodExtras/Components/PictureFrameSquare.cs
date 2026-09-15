using UnityEngine;

namespace CoreWoodExtras;

internal class PictureFrameSquare : PictureFrameBase
{
	public override Vector3 PivotOffset { get; set; } = new Vector3(0.4473f, 0.4473f, 0f);

	public override string Name { get; set; } = "$piece_mm_first_pictureframe_square";
}
