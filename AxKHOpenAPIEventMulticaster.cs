using System;
using System.Runtime.InteropServices;
using KHOpenAPILib;

namespace AxKHOpenAPILib
{
	// Token: 0x02000015 RID: 21
	[ClassInterface(ClassInterfaceType.None)]
	public class AxKHOpenAPIEventMulticaster : _DKHOpenAPIEvents
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00003221 File Offset: 0x00001421
		public AxKHOpenAPIEventMulticaster(AxKHOpenAPI parent)
		{
			this.parent = parent;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003230 File Offset: 0x00001430
		public virtual void OnReceiveTrData(string sScrNo, string sRQName, string sTrCode, string sRecordName, string sPrevNext, int nDataLength, string sErrorCode, string sMessage, string sSplmMsg)
		{
			_DKHOpenAPIEvents_OnReceiveTrDataEvent e = new _DKHOpenAPIEvents_OnReceiveTrDataEvent(sScrNo, sRQName, sTrCode, sRecordName, sPrevNext, nDataLength, sErrorCode, sMessage, sSplmMsg);
			this.parent.RaiseOnOnReceiveTrData(this.parent, e);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003264 File Offset: 0x00001464
		public virtual void OnReceiveRealData(string sRealKey, string sRealType, string sRealData)
		{
			_DKHOpenAPIEvents_OnReceiveRealDataEvent e = new _DKHOpenAPIEvents_OnReceiveRealDataEvent(sRealKey, sRealType, sRealData);
			this.parent.RaiseOnOnReceiveRealData(this.parent, e);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000328C File Offset: 0x0000148C
		public virtual void OnReceiveMsg(string sScrNo, string sRQName, string sTrCode, string sMsg)
		{
			_DKHOpenAPIEvents_OnReceiveMsgEvent e = new _DKHOpenAPIEvents_OnReceiveMsgEvent(sScrNo, sRQName, sTrCode, sMsg);
			this.parent.RaiseOnOnReceiveMsg(this.parent, e);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000032B8 File Offset: 0x000014B8
		public virtual void OnReceiveChejanData(string sGubun, int nItemCnt, string sFIdList)
		{
			_DKHOpenAPIEvents_OnReceiveChejanDataEvent e = new _DKHOpenAPIEvents_OnReceiveChejanDataEvent(sGubun, nItemCnt, sFIdList);
			this.parent.RaiseOnOnReceiveChejanData(this.parent, e);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000032E0 File Offset: 0x000014E0
		public virtual void OnEventConnect(int nErrCode)
		{
			_DKHOpenAPIEvents_OnEventConnectEvent e = new _DKHOpenAPIEvents_OnEventConnectEvent(nErrCode);
			this.parent.RaiseOnOnEventConnect(this.parent, e);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003308 File Offset: 0x00001508
		public virtual void OnReceiveInvestRealData(string sRealKey)
		{
			_DKHOpenAPIEvents_OnReceiveInvestRealDataEvent e = new _DKHOpenAPIEvents_OnReceiveInvestRealDataEvent(sRealKey);
			this.parent.RaiseOnOnReceiveInvestRealData(this.parent, e);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003330 File Offset: 0x00001530
		public virtual void OnReceiveRealCondition(string sTrCode, string strType, string strConditionName, string strConditionIndex)
		{
			_DKHOpenAPIEvents_OnReceiveRealConditionEvent e = new _DKHOpenAPIEvents_OnReceiveRealConditionEvent(sTrCode, strType, strConditionName, strConditionIndex);
			this.parent.RaiseOnOnReceiveRealCondition(this.parent, e);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000335C File Offset: 0x0000155C
		public virtual void OnReceiveTrCondition(string sScrNo, string strCodeList, string strConditionName, int nIndex, int nNext)
		{
			_DKHOpenAPIEvents_OnReceiveTrConditionEvent e = new _DKHOpenAPIEvents_OnReceiveTrConditionEvent(sScrNo, strCodeList, strConditionName, nIndex, nNext);
			this.parent.RaiseOnOnReceiveTrCondition(this.parent, e);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003388 File Offset: 0x00001588
		public virtual void OnReceiveConditionVer(int lRet, string sMsg)
		{
			_DKHOpenAPIEvents_OnReceiveConditionVerEvent e = new _DKHOpenAPIEvents_OnReceiveConditionVerEvent(lRet, sMsg);
			this.parent.RaiseOnOnReceiveConditionVer(this.parent, e);
		}

		// Token: 0x0400002D RID: 45
		private AxKHOpenAPI parent;
	}
}
