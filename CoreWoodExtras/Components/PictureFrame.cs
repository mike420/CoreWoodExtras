using UnityEngine;

namespace CoreWoodExtras;

public class PictureFrame : PictureFrameBase
{
	public override Vector3 PivotOffset { get; set; } = new Vector3(0.729f, 0.4473f, 0f);

	public override string Name { get; set; } = "$piece_mm_first_pictureframe";
}
