using UnityEngine;
using UnityEngine.EventSystems;

public class HomeFooterManager : MonoBehaviour
{
	[Header("========== Self ==========")]
	[SerializeField] private Transform[] buttons;
	[SerializeField] private Transform[] seperates;

	[Header("========== Tabs ==========")]
	[SerializeField] private Transform[] tabs;

	public void TabAnimate()
	{
		GameObject btnSelect = EventSystem.current.currentSelectedGameObject;

		for (int i = 0; i < buttons.Length; i++)
		{
			if (buttons[i].name == btnSelect.name)
				continue;

			buttons[i].GetComponent<FooterTabInfo>().NormalMode();
		}
	}

	public void ShowTab(Transform tab)
	{
		for (int i = 0; i < tabs.Length; i++)
		{
			if (tabs[i].name == tab.name) continue;

			tabs[i].gameObject.SetActive(false);
		}

		tab.gameObject.SetActive(true);
	}
}
