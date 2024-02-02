using System;
using System.ComponentModel;
using System.Windows.Forms;
using KHOpenAPILib;

namespace AxKHOpenAPILib
{
	// Token: 0x02000002 RID: 2
	[DefaultEvent("OnReceiveTrData")]
	[DesignTimeVisible(true)]
	[AxHost.ClsidAttribute("{a1574a0d-6bfa-4bd7-9020-ded88711818d}")]
	public class AxKHOpenAPI : AxHost
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public AxKHOpenAPI() : base("a1574a0d-6bfa-4bd7-9020-ded88711818d")
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
		// (remove) Token: 0x06000003 RID: 3 RVA: 0x00002098 File Offset: 0x00000298
		public event _DKHOpenAPIEvents_OnReceiveTrDataEventHandler OnReceiveTrData;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000004 RID: 4 RVA: 0x000020D0 File Offset: 0x000002D0
		// (remove) Token: 0x06000005 RID: 5 RVA: 0x00002108 File Offset: 0x00000308
		public event _DKHOpenAPIEvents_OnReceiveRealDataEventHandler OnReceiveRealData;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000006 RID: 6 RVA: 0x00002140 File Offset: 0x00000340
		// (remove) Token: 0x06000007 RID: 7 RVA: 0x00002178 File Offset: 0x00000378
		public event _DKHOpenAPIEvents_OnReceiveMsgEventHandler OnReceiveMsg;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000008 RID: 8 RVA: 0x000021B0 File Offset: 0x000003B0
		// (remove) Token: 0x06000009 RID: 9 RVA: 0x000021E8 File Offset: 0x000003E8
		public event _DKHOpenAPIEvents_OnReceiveChejanDataEventHandler OnReceiveChejanData;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600000A RID: 10 RVA: 0x00002220 File Offset: 0x00000420
		// (remove) Token: 0x0600000B RID: 11 RVA: 0x00002258 File Offset: 0x00000458
		public event _DKHOpenAPIEvents_OnEventConnectEventHandler OnEventConnect;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600000C RID: 12 RVA: 0x00002290 File Offset: 0x00000490
		// (remove) Token: 0x0600000D RID: 13 RVA: 0x000022C8 File Offset: 0x000004C8
		public event _DKHOpenAPIEvents_OnReceiveInvestRealDataEventHandler OnReceiveInvestRealData;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600000E RID: 14 RVA: 0x00002300 File Offset: 0x00000500
		// (remove) Token: 0x0600000F RID: 15 RVA: 0x00002338 File Offset: 0x00000538
		public event _DKHOpenAPIEvents_OnReceiveRealConditionEventHandler OnReceiveRealCondition;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000010 RID: 16 RVA: 0x00002370 File Offset: 0x00000570
		// (remove) Token: 0x06000011 RID: 17 RVA: 0x000023A8 File Offset: 0x000005A8
		public event _DKHOpenAPIEvents_OnReceiveTrConditionEventHandler OnReceiveTrCondition;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000012 RID: 18 RVA: 0x000023E0 File Offset: 0x000005E0
		// (remove) Token: 0x06000013 RID: 19 RVA: 0x00002418 File Offset: 0x00000618
		public event _DKHOpenAPIEvents_OnReceiveConditionVerEventHandler OnReceiveConditionVer;

		// Token: 0x06000014 RID: 20 RVA: 0x00002450 File Offset: 0x00000650
		public virtual int CommConnect()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CommConnect", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.CommConnect();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000247E File Offset: 0x0000067E
		public virtual void CommTerminate()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CommTerminate", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.CommTerminate();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000024A0 File Offset: 0x000006A0
		public virtual int CommRqData(string sRQName, string sTrCode, int nPrevNext, string sScreenNo)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CommRqData", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.CommRqData(sRQName, sTrCode, nPrevNext, sScreenNo);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000024D4 File Offset: 0x000006D4
		public virtual string GetLoginInfo(string sTag)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetLoginInfo", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetLoginInfo(sTag);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002504 File Offset: 0x00000704
		public virtual int SendOrder(string sRQName, string sScreenNo, string sAccNo, int nOrderType, string sCode, int nQty, int nPrice, string sHogaGb, string sOrgOrderNo)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOrder", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.SendOrder(sRQName, sScreenNo, sAccNo, nOrderType, sCode, nQty, nPrice, sHogaGb, sOrgOrderNo);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002544 File Offset: 0x00000744
		public virtual int SendOrderFO(string sRQName, string sScreenNo, string sAccNo, string sCode, int lOrdKind, string sSlbyTp, string sOrdTp, int lQty, string sPrice, string sOrgOrdNo)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOrderFO", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.SendOrderFO(sRQName, sScreenNo, sAccNo, sCode, lOrdKind, sSlbyTp, sOrdTp, lQty, sPrice, sOrgOrdNo);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002583 File Offset: 0x00000783
		public virtual void SetInputValue(string sID, string sValue)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetInputValue", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetInputValue(sID, sValue);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000025A8 File Offset: 0x000007A8
		public virtual int SetOutputFID(string sID)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetOutputFID", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.SetOutputFID(sID);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025D8 File Offset: 0x000007D8
		public virtual string CommGetData(string sJongmokCode, string sRealType, string sFieldName, int nIndex, string sInnerFieldName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CommGetData", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.CommGetData(sJongmokCode, sRealType, sFieldName, nIndex, sInnerFieldName);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000260D File Offset: 0x0000080D
		public virtual void DisconnectRealData(string sScnNo)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("DisconnectRealData", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.DisconnectRealData(sScnNo);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002630 File Offset: 0x00000830
		public virtual int GetRepeatCnt(string sTrCode, string sRecordName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetRepeatCnt", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetRepeatCnt(sTrCode, sRecordName);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002660 File Offset: 0x00000860
		public virtual int CommKwRqData(string sArrCode, int bNext, int nCodeCount, int nTypeFlag, string sRQName, string sScreenNo)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CommKwRqData", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.CommKwRqData(sArrCode, bNext, nCodeCount, nTypeFlag, sRQName, sScreenNo);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002698 File Offset: 0x00000898
		public virtual string GetAPIModulePath()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetAPIModulePath", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetAPIModulePath();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000026C8 File Offset: 0x000008C8
		public virtual string GetCodeListByMarket(string sMarket)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetCodeListByMarket", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetCodeListByMarket(sMarket);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000026F8 File Offset: 0x000008F8
		public virtual int GetConnectState()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetConnectState", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetConnectState();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002728 File Offset: 0x00000928
		public virtual string GetMasterCodeName(string sTrCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetMasterCodeName", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetMasterCodeName(sTrCode);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002758 File Offset: 0x00000958
		public virtual int GetMasterListedStockCnt(string sTrCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetMasterListedStockCnt", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetMasterListedStockCnt(sTrCode);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002788 File Offset: 0x00000988
		public virtual string GetMasterConstruction(string sTrCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetMasterConstruction", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetMasterConstruction(sTrCode);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000027B8 File Offset: 0x000009B8
		public virtual string GetMasterListedStockDate(string sTrCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetMasterListedStockDate", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetMasterListedStockDate(sTrCode);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000027E8 File Offset: 0x000009E8
		public virtual string GetMasterLastPrice(string sTrCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetMasterLastPrice", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetMasterLastPrice(sTrCode);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002818 File Offset: 0x00000A18
		public virtual string GetMasterStockState(string sTrCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetMasterStockState", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetMasterStockState(sTrCode);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002848 File Offset: 0x00000A48
		public virtual int GetDataCount(string strRecordName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetDataCount", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetDataCount(strRecordName);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002878 File Offset: 0x00000A78
		public virtual string GetOutputValue(string strRecordName, int nRepeatIdx, int nItemIdx)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetOutputValue", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetOutputValue(strRecordName, nRepeatIdx, nItemIdx);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000028AC File Offset: 0x00000AAC
		public virtual string GetCommData(string strTrCode, string strRecordName, int nIndex, string strItemName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetCommData", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetCommData(strTrCode, strRecordName, nIndex, strItemName);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000028E0 File Offset: 0x00000AE0
		public virtual string GetCommRealData(string sTrCode, int nFid)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetCommRealData", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetCommRealData(sTrCode, nFid);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002910 File Offset: 0x00000B10
		public virtual string GetChejanData(int nFid)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetChejanData", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetChejanData(nFid);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002940 File Offset: 0x00000B40
		public virtual string GetThemeGroupList(int nType)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetThemeGroupList", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetThemeGroupList(nType);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002970 File Offset: 0x00000B70
		public virtual string GetThemeGroupCode(string strThemeCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetThemeGroupCode", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetThemeGroupCode(strThemeCode);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000029A0 File Offset: 0x00000BA0
		public virtual string GetFutureList()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetFutureList", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetFutureList();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000029D0 File Offset: 0x00000BD0
		public virtual string GetFutureCodeByIndex(int nIndex)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetFutureCodeByIndex", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetFutureCodeByIndex(nIndex);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002A00 File Offset: 0x00000C00
		public virtual string GetActPriceList()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetActPriceList", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetActPriceList();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002A30 File Offset: 0x00000C30
		public virtual string GetMonthList()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetMonthList", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetMonthList();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002A60 File Offset: 0x00000C60
		public virtual string GetOptionCode(string strActPrice, int nCp, string strMonth)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetOptionCode", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetOptionCode(strActPrice, nCp, strMonth);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002A94 File Offset: 0x00000C94
		public virtual string GetOptionCodeByMonth(string sTrCode, int nCp, string strMonth)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetOptionCodeByMonth", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetOptionCodeByMonth(sTrCode, nCp, strMonth);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002AC8 File Offset: 0x00000CC8
		public virtual string GetOptionCodeByActPrice(string sTrCode, int nCp, int nTick)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetOptionCodeByActPrice", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetOptionCodeByActPrice(sTrCode, nCp, nTick);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002AFC File Offset: 0x00000CFC
		public virtual string GetSFutureList(string strBaseAssetCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetSFutureList", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetSFutureList(strBaseAssetCode);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002B2C File Offset: 0x00000D2C
		public virtual string GetSFutureCodeByIndex(string strBaseAssetCode, int nIndex)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetSFutureCodeByIndex", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetSFutureCodeByIndex(strBaseAssetCode, nIndex);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002B5C File Offset: 0x00000D5C
		public virtual string GetSActPriceList(string strBaseAssetGb)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetSActPriceList", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetSActPriceList(strBaseAssetGb);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002B8C File Offset: 0x00000D8C
		public virtual string GetSMonthList(string strBaseAssetGb)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetSMonthList", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetSMonthList(strBaseAssetGb);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002BBC File Offset: 0x00000DBC
		public virtual string GetSOptionCode(string strBaseAssetGb, string strActPrice, int nCp, string strMonth)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetSOptionCode", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetSOptionCode(strBaseAssetGb, strActPrice, nCp, strMonth);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002BF0 File Offset: 0x00000DF0
		public virtual string GetSOptionCodeByMonth(string strBaseAssetGb, string sTrCode, int nCp, string strMonth)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetSOptionCodeByMonth", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetSOptionCodeByMonth(strBaseAssetGb, sTrCode, nCp, strMonth);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002C24 File Offset: 0x00000E24
		public virtual string GetSOptionCodeByActPrice(string strBaseAssetGb, string sTrCode, int nCp, int nTick)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetSOptionCodeByActPrice", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetSOptionCodeByActPrice(strBaseAssetGb, sTrCode, nCp, nTick);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002C58 File Offset: 0x00000E58
		public virtual string GetSFOBasisAssetList()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetSFOBasisAssetList", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetSFOBasisAssetList();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002C88 File Offset: 0x00000E88
		public virtual string GetOptionATM()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetOptionATM", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetOptionATM();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002CB8 File Offset: 0x00000EB8
		public virtual string GetSOptionATM(string strBaseAssetGb)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetSOptionATM", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetSOptionATM(strBaseAssetGb);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002CE8 File Offset: 0x00000EE8
		public virtual string GetBranchCodeName()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetBranchCodeName", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetBranchCodeName();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002D18 File Offset: 0x00000F18
		public virtual int CommInvestRqData(string sMarketGb, string sRQName, string sScreenNo)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("CommInvestRqData", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.CommInvestRqData(sMarketGb, sRQName, sScreenNo);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002D4C File Offset: 0x00000F4C
		public virtual int SendOrderCredit(string sRQName, string sScreenNo, string sAccNo, int nOrderType, string sCode, int nQty, int nPrice, string sHogaGb, string sCreditGb, string sLoanDate, string sOrgOrderNo)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendOrderCredit", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.SendOrderCredit(sRQName, sScreenNo, sAccNo, nOrderType, sCode, nQty, nPrice, sHogaGb, sCreditGb, sLoanDate, sOrgOrderNo);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002D90 File Offset: 0x00000F90
		public virtual string KOA_Functions(string sFunctionName, string sParam)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("KOA_Functions", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.KOA_Functions(sFunctionName, sParam);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002DC0 File Offset: 0x00000FC0
		public virtual int SetInfoData(string sInfoData)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetInfoData", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.SetInfoData(sInfoData);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002DF0 File Offset: 0x00000FF0
		public virtual int SetRealReg(string strScreenNo, string strCodeList, string strFidList, string strOptType)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetRealReg", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.SetRealReg(strScreenNo, strCodeList, strFidList, strOptType);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002E24 File Offset: 0x00001024
		public virtual int GetConditionLoad()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetConditionLoad", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetConditionLoad();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002E54 File Offset: 0x00001054
		public virtual string GetConditionNameList()
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetConditionNameList", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetConditionNameList();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002E84 File Offset: 0x00001084
		public virtual int SendCondition(string strScrNo, string strConditionName, int nIndex, int nSearch)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendCondition", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.SendCondition(strScrNo, strConditionName, nIndex, nSearch);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002EB7 File Offset: 0x000010B7
		public virtual void SendConditionStop(string strScrNo, string strConditionName, int nIndex)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SendConditionStop", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SendConditionStop(strScrNo, strConditionName, nIndex);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002EDC File Offset: 0x000010DC
		public virtual object GetCommDataEx(string strTrCode, string strRecordName)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetCommDataEx", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetCommDataEx(strTrCode, strRecordName);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002F0C File Offset: 0x0000110C
		public virtual void SetRealRemove(string strScrNo, string strDelCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("SetRealRemove", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			this.ocx.SetRealRemove(strScrNo, strDelCode);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002F30 File Offset: 0x00001130
		public virtual int GetMarketType(string sTrCode)
		{
			if (this.ocx == null)
			{
				throw new AxHost.InvalidActiveXStateException("GetMarketType", AxHost.ActiveXInvokeKind.MethodInvoke);
			}
			return this.ocx.GetMarketType(sTrCode);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002F60 File Offset: 0x00001160
		protected override void CreateSink()
		{
			try
			{
				this.eventMulticaster = new AxKHOpenAPIEventMulticaster(this);
				this.cookie = new AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(_DKHOpenAPIEvents));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002FB0 File Offset: 0x000011B0
		protected override void DetachSink()
		{
			try
			{
				this.cookie.Disconnect();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002FE0 File Offset: 0x000011E0
		protected override void AttachInterfaces()
		{
			try
			{
				this.ocx = (_DKHOpenAPI)base.GetOcx();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003014 File Offset: 0x00001214
		internal void RaiseOnOnReceiveTrData(object sender, _DKHOpenAPIEvents_OnReceiveTrDataEvent e)
		{
			if (this.OnReceiveTrData != null)
			{
				this.OnReceiveTrData(sender, e);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000302B File Offset: 0x0000122B
		internal void RaiseOnOnReceiveRealData(object sender, _DKHOpenAPIEvents_OnReceiveRealDataEvent e)
		{
			if (this.OnReceiveRealData != null)
			{
				this.OnReceiveRealData(sender, e);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003042 File Offset: 0x00001242
		internal void RaiseOnOnReceiveMsg(object sender, _DKHOpenAPIEvents_OnReceiveMsgEvent e)
		{
			if (this.OnReceiveMsg != null)
			{
				this.OnReceiveMsg(sender, e);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003059 File Offset: 0x00001259
		internal void RaiseOnOnReceiveChejanData(object sender, _DKHOpenAPIEvents_OnReceiveChejanDataEvent e)
		{
			if (this.OnReceiveChejanData != null)
			{
				this.OnReceiveChejanData(sender, e);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003070 File Offset: 0x00001270
		internal void RaiseOnOnEventConnect(object sender, _DKHOpenAPIEvents_OnEventConnectEvent e)
		{
			if (this.OnEventConnect != null)
			{
				this.OnEventConnect(sender, e);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003087 File Offset: 0x00001287
		internal void RaiseOnOnReceiveInvestRealData(object sender, _DKHOpenAPIEvents_OnReceiveInvestRealDataEvent e)
		{
			if (this.OnReceiveInvestRealData != null)
			{
				this.OnReceiveInvestRealData(sender, e);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000309E File Offset: 0x0000129E
		internal void RaiseOnOnReceiveRealCondition(object sender, _DKHOpenAPIEvents_OnReceiveRealConditionEvent e)
		{
			if (this.OnReceiveRealCondition != null)
			{
				this.OnReceiveRealCondition(sender, e);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000030B5 File Offset: 0x000012B5
		internal void RaiseOnOnReceiveTrCondition(object sender, _DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
		{
			if (this.OnReceiveTrCondition != null)
			{
				this.OnReceiveTrCondition(sender, e);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000030CC File Offset: 0x000012CC
		internal void RaiseOnOnReceiveConditionVer(object sender, _DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
		{
			if (this.OnReceiveConditionVer != null)
			{
				this.OnReceiveConditionVer(sender, e);
			}
		}

		// Token: 0x04000001 RID: 1
		private _DKHOpenAPI ocx;

		// Token: 0x04000002 RID: 2
		private AxKHOpenAPIEventMulticaster eventMulticaster;

		// Token: 0x04000003 RID: 3
		private AxHost.ConnectionPointCookie cookie;
	}
}
