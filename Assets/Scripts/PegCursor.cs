using System;
using UnityEngine;
public class PegCursor : MonoBehaviour
{
	public enum Mode
	{
		UP,
		DOWN,
		OVER,
		DRAG,
		STOPDRAG,
		WAITING,
		STOPWAITING,
		LEFTARROW,
		RIGHTARROW,
		NONE
	}
	public Texture2D m_cursorUp;
	public Vector2 m_cursorUpHotspot = Vector2.zero;
	public Texture2D m_cursorDown;
	public Vector2 m_cursorDownHotspot = Vector2.zero;
	public Texture2D m_cursorDrag;
	public Vector2 m_cursorDragHotspot = Vector2.zero;
	public Texture2D m_cursorOver;
	public Vector2 m_cursorOverHotspot = Vector2.zero;
	public Texture2D m_cursorWaiting;
	public Vector2 m_cursorWaitingHotspot = Vector2.zero;
	public Texture2D m_cursorWaitingDown;
	public Vector2 m_cursorWaitingDownHotspot = Vector2.zero;
	public Texture2D m_cursorWaitingUp;
	public Vector2 m_cursorWaitingUpHotspot = Vector2.zero;
	public Texture2D m_leftArrow;
	public Vector2 m_leftArrowHotspot = Vector2.zero;
	public Texture2D m_rightArrow;
	public Vector2 m_rightArrowHotspot = Vector2.zero;
	public Texture2D m_cursorUp64;
	public Vector2 m_cursorUpHotspot64 = Vector2.zero;
	public Texture2D m_cursorDown64;
	public Vector2 m_cursorDownHotspot64 = Vector2.zero;
	public Texture2D m_cursorDrag64;
	public Vector2 m_cursorDragHotspot64 = Vector2.zero;
	public Texture2D m_cursorOver64;
	public Vector2 m_cursorOverHotspot64 = Vector2.zero;
	public Texture2D m_cursorWaiting64;
	public Vector2 m_cursorWaitingHotspot64 = Vector2.zero;
	public Texture2D m_cursorWaitingDown64;
	public Vector2 m_cursorWaitingDownHotspot64 = Vector2.zero;
	public Texture2D m_cursorWaitingUp64;
	public Vector2 m_cursorWaitingUpHotspot64 = Vector2.zero;
	public Texture2D m_leftArrow64;
	public Vector2 m_leftArrowHotspot64 = Vector2.zero;
	public Texture2D m_rightArrow64;
	public Vector2 m_rightArrowHotspot64 = Vector2.zero;
	public GameObject m_explosionPrefab;
	private Texture2D m_cursorTexture;
	private PegCursor.Mode m_currentMode;
	private static PegCursor s_instance;
	private void Awake()
	{
		PegCursor.s_instance = this;
	}
	private void OnDestroy()
	{
		PegCursor.s_instance = null;
	}
	public static PegCursor Get()
	{
		return PegCursor.s_instance;
	}
	public void Show()
	{
		Screen.showCursor = true;
	}
	public void Hide()
	{
		Screen.showCursor = false;
	}
	public void SetMode(PegCursor.Mode mode)
	{
		bool flag = false;
		if (this.m_currentMode == PegCursor.Mode.WAITING && mode != PegCursor.Mode.STOPWAITING)
		{
			if (mode == PegCursor.Mode.DOWN)
			{
				if (flag)
				{
					Cursor.SetCursor(this.m_cursorWaitingDown64, this.m_cursorWaitingDownHotspot64, CursorMode.Auto);
				}
				else
				{
					Cursor.SetCursor(this.m_cursorWaitingDown, this.m_cursorWaitingDownHotspot, CursorMode.Auto);
				}
			}
			else
			{
				if (mode == PegCursor.Mode.UP)
				{
					if (flag)
					{
						Cursor.SetCursor(this.m_cursorWaiting64, this.m_cursorWaitingHotspot64, CursorMode.Auto);
					}
					else
					{
						Cursor.SetCursor(this.m_cursorWaiting, this.m_cursorWaitingHotspot, CursorMode.Auto);
					}
				}
			}
			return;
		}
		if (this.m_currentMode == PegCursor.Mode.DRAG && mode != PegCursor.Mode.STOPDRAG)
		{
			return;
		}
		this.m_currentMode = mode;
		if (flag)
		{
			switch (mode)
			{
			case PegCursor.Mode.UP:
				Cursor.SetCursor(this.m_cursorUp64, this.m_cursorUpHotspot64, CursorMode.Auto);
				break;
			case PegCursor.Mode.DOWN:
				Cursor.SetCursor(this.m_cursorDown64, this.m_cursorDownHotspot64, CursorMode.Auto);
				break;
			case PegCursor.Mode.OVER:
				Cursor.SetCursor(this.m_cursorUp64, this.m_cursorUpHotspot64, CursorMode.Auto);
				break;
			case PegCursor.Mode.DRAG:
				Cursor.SetCursor(this.m_cursorDrag64, this.m_cursorDragHotspot64, CursorMode.Auto);
				break;
			case PegCursor.Mode.STOPDRAG:
			case PegCursor.Mode.STOPWAITING:
				Cursor.SetCursor(this.m_cursorUp64, this.m_cursorUpHotspot64, CursorMode.Auto);
				break;
			case PegCursor.Mode.WAITING:
				Cursor.SetCursor(this.m_cursorWaiting64, this.m_cursorWaitingHotspot64, CursorMode.Auto);
				break;
			case PegCursor.Mode.LEFTARROW:
				Cursor.SetCursor(this.m_leftArrow64, this.m_leftArrowHotspot64, CursorMode.Auto);
				break;
			case PegCursor.Mode.RIGHTARROW:
				Cursor.SetCursor(this.m_rightArrow64, this.m_rightArrowHotspot64, CursorMode.Auto);
				break;
			}
		}
		else
		{
			switch (mode)
			{
			case PegCursor.Mode.UP:
				Cursor.SetCursor(this.m_cursorUp, this.m_cursorUpHotspot, CursorMode.Auto);
				break;
			case PegCursor.Mode.DOWN:
				Cursor.SetCursor(this.m_cursorDown, this.m_cursorDownHotspot, CursorMode.Auto);
				break;
			case PegCursor.Mode.OVER:
				Cursor.SetCursor(this.m_cursorUp, this.m_cursorUpHotspot, CursorMode.Auto);
				break;
			case PegCursor.Mode.DRAG:
				Cursor.SetCursor(this.m_cursorDrag, this.m_cursorDragHotspot, CursorMode.Auto);
				break;
			case PegCursor.Mode.STOPDRAG:
			case PegCursor.Mode.STOPWAITING:
				Cursor.SetCursor(this.m_cursorUp, this.m_cursorUpHotspot, CursorMode.Auto);
				break;
			case PegCursor.Mode.WAITING:
				Cursor.SetCursor(this.m_cursorWaiting, this.m_cursorWaitingHotspot, CursorMode.Auto);
				break;
			case PegCursor.Mode.LEFTARROW:
				Cursor.SetCursor(this.m_leftArrow, this.m_leftArrowHotspot, CursorMode.Auto);
				break;
			case PegCursor.Mode.RIGHTARROW:
				Cursor.SetCursor(this.m_rightArrow, this.m_rightArrowHotspot, CursorMode.Auto);
				break;
			}
		}
	}
	public PegCursor.Mode GetMode()
	{
		return this.m_currentMode;
	}
	public GameObject GetExplosionPrefab()
	{
		return this.m_explosionPrefab;
	}
}
