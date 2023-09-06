using UnityEngine;
using UnityEngine.UI;

public class FooterTabInfo : MonoBehaviour
{
	[Header("========== Seperates ==========")]
	[SerializeField] private RectTransform seperateLeft;
	[SerializeField] private RectTransform seperateRight;
	[SerializeField] private Vector3 orgLeftPos;
	[SerializeField] private Vector3 orgRightPos;

	[Header("========== Button ==========")]
	[SerializeField] private Vector3 orgPos;
	[SerializeField] private Vector3 selPos;
	[SerializeField] private Vector3 orgScale = Vector3.one;
	[SerializeField] private Vector3 selScale;

	[Header("========== Status ==========")]
	[SerializeField] private bool isDefaultChoose; // Original Status
	[SerializeField] private RectTransform icon;
	[SerializeField] private Text title;

	private void OnEnable()
	{
		orgPos = icon.anchoredPosition3D;
		selPos = new Vector3(orgPos.x, 85, orgPos.z);

		orgLeftPos = seperateLeft != null ? seperateLeft.anchoredPosition3D : Vector3.zero;
		orgRightPos = seperateRight != null ? seperateRight.anchoredPosition3D : Vector3.zero;

		if (isDefaultChoose)
		{
			SelectMode();
		}
	}

	public void SelectMode()
	{
		if (seperateLeft != null)
			seperateLeft.anchoredPosition3D = new Vector3(orgLeftPos.x - 24f, orgLeftPos.y, orgLeftPos.z);

		if (seperateRight != null)
			seperateRight.anchoredPosition3D = new Vector3(orgRightPos.x + 24f, orgRightPos.y, orgRightPos.z);

		icon.anchoredPosition3D = selPos;
		icon.localScale = selScale;

		title.gameObject.SetActive(true);
	}

	public void NormalMode()
	{
		if (seperateLeft != null)
			seperateLeft.anchoredPosition3D = orgLeftPos;

		if (seperateRight != null)
			seperateRight.anchoredPosition3D = orgRightPos;

		icon.anchoredPosition3D = orgPos;
		icon.localScale = orgScale;

		title.gameObject.SetActive(false);
	}
}
