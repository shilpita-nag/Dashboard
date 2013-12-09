Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data.OracleClient
Imports System.Data
'Declaration
<ObsoleteAttribute("OracleConnection has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", _
 False)>
Partial Class Dashboard
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As New DataTable()
        dt.Columns.Add("CASTER", GetType(String))
        dt.Columns.Add("ON_DATE_SPEED", GetType(String))
        dt.Columns.Add("CUMULATIVE SPEED", GetType(String))
        dt.Rows.Add(" ", " ", " ")
        dt.Rows.Add(" ", " ", " ")
        dt.Rows.Add(" ", " ", " ")
        dt.Rows.Add("Avg speed", " ", " ")
        grd1.DataSource = dt
        grd1.DataBind()

        Dim d1 As New DataTable()
        d1.Columns.Add(" PROCESS LOSS DELAY REASONS", GetType(String))
        d1.Columns.Add("ON DATE", GetType(String))
        d1.Columns.Add("CUMULATIVE", GetType(String))
        d1.Rows.Add("CAP OFF/Shut down", " ", " ")
        d1.Rows.Add("Caster Start Ramping", " ", " ")
        d1.Rows.Add("FTC:Planned", " ", " ")
        d1.Rows.Add("HSH DURE TO MAIN/ETC", " ", " ")
        d1.Rows.Add("RESTRICTED TPUT DUE TO QUALITY", " ", " ")
        d1.Rows.Add("Ramming", " ", " ")
        d1.Rows.Add("SEN Lance:Planned", " ", " ")
        d1.Rows.Add("shroud change", " ", " ")
        d1.Rows.Add("SEN Lance:Operation", " ", " ")
        d1.Rows.Add("Transition Metal", " ", " ")
        d1.Rows.Add("Tube Change: Operation", " ", " ")
        d1.Rows.Add("Tube change: Planned", " ", " ")
        d1.Rows.Add("Others", " ", " ")
        G1.DataSource = d1
        G1.DataBind()

        Dim d2 As New DataTable()
        d2.Columns.Add("MECH DELAY REASONS", GetType(String))
        d2.Columns.Add("ON DATE", GetType(String))
        d2.Columns.Add("CUMULATIVE", GetType(String))
        d2.Rows.Add("Mold water/spray water", " ", " ")
        d2.Rows.Add("Turret problem", " ", " ")
        d2.Rows.Add("spray water not matching", " ", " ")
        d2.Rows.Add("MLF due to inter roll bulging", " ", " ")
        d2.Rows.Add("S/G Hyd. Pressure unhealthy", " ", " ")
        d2.Rows.Add("shroud manipulator problem", " ", " ")
        d2.Rows.Add("Drive current high", " ", "  ")
        d2.Rows.Add("others", " ", " ")
        G2.DataSource = d2
        G2.DataBind()

        Dim d3 As New DataTable()
        d3.Columns.Add("IEM DELAY REASONS", GetType(String))
        d3.Columns.Add("ON DATE", GetType(String))
        d3.Columns.Add("CUMULATIVE", GetType(String))
        d3.Rows.Add("RAM Problem", " ", " ")
        d3.Rows.Add("Drive current high", " ", " ")
        d3.Rows.Add("TCM", " ", " ")
        d3.Rows.Add("SMM", " ", " ")
        d3.Rows.Add("Roller Table", " ", " ")
        d3.Rows.Add("Temperature Problem", " ", " ")
        d3.Rows.Add("FCV(spary water) malfunctioning", " ", " ")
        d3.Rows.Add("CT Bed problem", " ", " ")
        d3.Rows.Add("Crane Delay", " ", " ")
        d3.Rows.Add("POWER DIP", " ", " ")
        d3.Rows.Add("BDS not working", " ", " ")
        d3.Rows.Add("others", " ", " ")
        G3.DataSource = d3
        G3.DataBind()

        Dim d4 As New DataTable()
        d4.Columns.Add("HIGH SUPERHEAT DELAY REASONS", GetType(String))
        d4.Columns.Add("ON DATE", GetType(String))
        d4.Columns.Add("CUMULATIVE", GetType(String))
        d4.Rows.Add("High 'S'", " ", " ")
        d4.Rows.Add("High Superheat from LF1", " ", " ")
        d4.Rows.Add("High Superheat from LF2", " ", " ")
        d4.Rows.Add("High Superheat from OLP", " ", " ")
        d4.Rows.Add("High Superheat from RH", " ", " ")
        d4.Rows.Add("LNC(Ladle Nozzle Choke", " ", " ")
        d4.Rows.Add("NFO(No Free Opening) Ladle", " ", " ")
        d4.Rows.Add("Others", " ", " ")
        G4.DataSource = d4
        G4.DataBind()

        Dim d5 As New DataTable()
        d5.Columns.Add("DELAY HEAT ARRIVAL REASONS", GetType(String))
        d5.Columns.Add("ON DATE", GetType(String))
        d5.Columns.Add("CUMULATIVE", GetType(String))
        d5.Rows.Add("LF1 Delay", " ", " ")
        d5.Rows.Add("LF2 Delay", " ", " ")
        d5.Rows.Add("OLP Delay", " ", " ")
        d5.Rows.Add("RH Problem", " ", " ")
        G5.DataSource = d5
        G5.DataBind()

        Dim d6 As New DataTable()
        d6.Columns.Add("CASTER OPERATION DELAY REASONS", GetType(String))
        d6.Columns.Add("ON DATE", GetType(String))
        d6.Columns.Add("CUMULATIVE", GetType(String))
        d6.Rows.Add("Abnormal Sticky Behavior", " ", " ")
        d6.Rows.Add("Flushimg", " ", " ")
        d6.Rows.Add("LTS", " ", " ")
        d6.Rows.Add("others", " ", " ")
        d6.Rows.Add("Shroud cleaning", " ", " ")
        d6.Rows.Add("Sticker/Crack", " ", " ")
        d6.Rows.Add("Cutting Problem", " ", " ")
        d6.Rows.Add("Level not matching", " ", " ")
        G6.DataSource = d6
        G6.DataBind()
    End Sub

    Protected Sub Display_Click(ByVal sender As Object, ByVal e As EventArgs)
        grd1.DataSource = Nothing
        grd1.DataBind()
        G1.DataSource = Nothing
        G1.DataBind()
        G2.DataSource = Nothing
        G2.DataBind()
        G3.DataSource = Nothing
        G3.DataBind()
        G4.DataSource = Nothing
        G4.DataBind()
        G5.DataSource = Nothing
        G5.DataBind()
        G6.DataSource = Nothing
        G6.DataBind()
        Dim dt As New DataTable()
        Dim dt1 As New DataTable()
        Dim orcon = New OracleConnection(" Data Source=orcl;Persist Security Info=True;User ID=system;Unicode=True;Password=root;")
        Dim q As String = "select decode(APS_ID_CASTER,'X','A', 'Y', 'B', 'Z','C','P','A','Q','B', 'R','C', 'A' , 'A', 'B','B','C', 'C')CASTER,round(sum(CSD_ACT_SPEED * CSD_CAST_TIME) / sum(CSD_CAST_TIME),3) cumulative_speed from (select distinct CSD_CAST_NO,CSD_ACT_SPEED,APS_ID_CASTER,CSD_CAST_TIME from T_CASTING_SPEED, T_A_PROD_PIECE, V_A_PROD_SLAB where APP_CAST_NO = CSD_CAST_NO and APS_CD_COMPANY = '1000' and APS_CD_DEPT = '0233' and APS_ID_PROC_CNTR = '01'and APP_CAST_NO = APS_CAST_NO and APP_CD_PROD_GRP  = '99' and TRUNC(APP_DT_SAP_PROD) between TRUNC(TO_DATE('" + datepicker.Text + "','MM-DD-YYYY'),'DDD') and TRUNC(TO_DATE('" + datepicker1.Text + "','MM-DD-YYYY'),'DDD')) group by decode(APS_ID_CASTER,'X', 'A', 'Y', 'B','Z','C','P','A','Q', 'B', 'R','C', 'A' , 'A', 'B','B','C', 'C') order by decode(APS_ID_CASTER,'X', 'A', 'Y', 'B','Z','C','P','A','Q','B', 'R','C', 'A' , 'A', 'B','B','C', 'C')"
        Dim p As String = "SELECT DECODE(APS_ID_CASTER,'X', 'A', 'Y', 'B','Z','C','P','A','Q','B', 'R','C', 'A' , 'A', 'B','B','C', 'C')CASTER,round(SUM(CSD_ACT_SPEED * CSD_CAST_TIME) / SUM(CSD_CAST_TIME),3) ON_DATE_SPEED FROM (SELECT DISTINCT CSD_CAST_NO,CSD_ACT_SPEED, APS_ID_CASTER, CSD_CAST_TIME FROM V_CASTING_SPEED, V_A_PROD_PIECE, V_A_PROD_SLAB WHERE APP_CAST_NO      = CSD_CAST_NO AND APS_CD_COMPANY   = '1000' AND APS_CD_DEPT      = '0233' AND APS_ID_PROC_CNTR = '01' AND APP_CAST_NO      = APS_CAST_NO AND APP_CD_PROD_GRP  = '99' AND trunc(APP_DT_SAP_PROD) = trunc(TO_DATE('" + datepicker.Text + "','MM-DD-YYYY'), 'DDD') ) GROUP BY DECODE(APS_ID_CASTER,'X', 'A', 'Y', 'B','Z','C','P','A','Q', 'B', 'R','C', 'A' , 'A', 'B','B','C', 'C') ORDER BY DECODE(APS_ID_CASTER,'X', 'A', 'Y', 'B','Z','C','P','A','Q', 'B', 'R','C', 'A' , 'A', 'B','B','C', 'C')"
        Dim cmd As New OracleCommand(p, orcon)
        Dim cmd1 As New OracleCommand(q, orcon)
        Dim adp As New OracleDataAdapter(cmd)
        Dim adp1 As New OracleDataAdapter(cmd1)
        adp.Fill(dt)
        adp1.Fill(dt1)
        dt.Columns.Add("CUMULATIVE SPEED", GetType(Double))

        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("CUMULATIVE SPEED") = dt1.Rows(i)("cumulative_speed")
        Next
        Dim s1 As Double = dt.Rows(0)("ON_DATE_SPEED")
        Dim s2 As Double = dt.Rows(1)("ON_DATE_SPEED")
        Dim s3 As Double = dt.Rows(2)("ON_DATE_SPEED")
        Dim s4 As Double = (s1 + s2 + s3) / 3
        Dim n1 As Double = dt.Rows(0)("CUMULATIVE SPEED")
        Dim n2 As Double = dt.Rows(1)("CUMULATIVE SPEED")
        Dim n3 As Double = dt.Rows(2)("CUMULATIVE SPEED")
        Dim n4 As Double = (s1 + s2 + s3) / 3
        dt.Rows.Add("Avg Speed", s4, n4)
        grd2.DataSource = dt
        grd2.DataBind()


        Dim dp As New DataTable()
        Dim dp2 As New DataTable()
        Dim p1 As String = "SELECT   SDC_CAST_RSN, DC_CAST_RSN,  NVL(SUM(CAD_DURATION), 0) TODT_DUR FROM V_CASTING_DELAY, V_HEAT_EVENT, V_SUB_DLY_CAST, V_DLY_CAST WHERE HTE_ID_WORK_UNIT = 'SC' AND SUBSTR(SDC_CAST_CD, 1, 3) IN ('COP', 'PDL', 'STI','ISQ', 'MPE','MPM') AND TRUNC(HTE_DT_START) BETWEEN TRUNC(TO_DATE('07-04-2013','DD-MM-YYYY'),'DDD') and TRUNC(TO_DATE('25-04-2013','DD-MM-YYYY'),'DDD') AND CAD_ID_PC_USRKEY = HTE_CAST_NO AND ((HTE_DT_END - HTE_DT_START) * 24 * 60) < 120 AND CAD_CD_DELAY = SDC_CAST_CD AND DC_CAST_CD = SUBSTR(SDC_CAST_CD, 1, 3) GROUP BY SDC_CAST_RSN, DC_CAST_RSN  ORDER BY DC_CAST_RSN"
        Dim q1 As String = "SELECT   SDC_CAST_RSN, DC_CAST_RSN,  NVL(SUM(DECODE(TRUNC(HTE_DT_START), TRUNC(TO_DATE('25-04-2013','DD-MM-YYYY'),'DDD'), CAD_DURATION)), 0) ONDT_DUR FROM V_CASTING_DELAY, V_HEAT_EVENT,V_SUB_DLY_CAST,V_DLY_CAST WHERE HTE_ID_WORK_UNIT = 'SC' AND SUBSTR(SDC_CAST_CD, 1, 3) IN ('COP', 'PDL', 'STI','ISQ', 'MPE','MPM') AND TRUNC(HTE_DT_START) = TRUNC(TO_DATE('25-04-2013','DD-MM-YYYY'),'DDD') AND CAD_ID_PC_USRKEY = HTE_CAST_NO AND ((HTE_DT_END - HTE_DT_START) * 24 * 60) < 120 AND CAD_CD_DELAY = SDC_CAST_CD AND DC_CAST_CD = SUBSTR(SDC_CAST_CD, 1, 3) GROUP BY SDC_CAST_RSN, DC_CAST_RSN ORDER BY DC_CAST_RSN"
        Dim orcon1 = New OracleConnection(" Data Source=orcl;Persist Security Info=True;User ID=system;Unicode=True;Password=root;")
        Dim cmd01 As New OracleCommand(p1, orcon)
        Dim cmd11 As New OracleCommand(q1, orcon)
        Dim adp01 As New OracleDataAdapter(cmd01)
        Dim adp11 As New OracleDataAdapter(cmd11)
        adp01.Fill(dp)
        adp11.Fill(dp2)
        Dim dp1 As New DataTable()
        dp1.Columns.Add("PROCESS LOSS DELAY REASONS", GetType(String))
        dp1.Columns.Add("ON DATE", GetType(Single))
        dp1.Columns.Add("CUMULATIVE", GetType(Single))
        dp1.Rows.Add("CAP OFF/Shut down", 0.0, 0.0)
        dp1.Rows.Add("Caster Start Ramping", 0.0, 0.0)
        dp1.Rows.Add("FTC: Planned", 0.0, 0.0)
        dp1.Rows.Add("HIGHSUPER HEAT DUE TO MAIN/FTC", 0.0, 0.0)
        dp1.Rows.Add("RESTRICTED TPUT DUE TO QUALITY", 0.0, 0.0)
        dp1.Rows.Add("Ramming", 0.0, 0.0)
        dp1.Rows.Add("SEN Lance:Planned", 0.0, 0.0)
        dp1.Rows.Add("shroud change", 0.0, 0.0)
        dp1.Rows.Add("Sen Lance:Operation", 0.0, 0.0)
        dp1.Rows.Add("Transition Metal", 0.0, 0.0)
        dp1.Rows.Add("Tube Change : Operation", 0.0, 0.0)
        dp1.Rows.Add("Tube change : Planned", 0.0, 0.0)
        dp1.Rows.Add("others", 0.0, 0.0)
        For i As Integer = 0 To dp1.Rows.Count - 1
            Dim j As Integer = 0
            For j = 0 To dp.Rows.Count - 1
                If dp.Rows(j)("SDC_CAST_RSN").ToString() = dp1.Rows(i)("PROCESS LOSS DELAY REASONS").ToString() AndAlso dp.Rows(j)("DC_CAST_RSN").ToString() = "Process Loss" Then
                    dp1.Rows(i)("CUMULATIVE") = dp.Rows(j)("TODT_DUR")
                End If
            Next
            Dim k As Integer = 0
            For k = 0 To dp2.Rows.Count - 1
                If dp2.Rows(k)("SDC_CAST_RSN").ToString() = dp1.Rows(i)("PROCESS LOSS DELAY REASONS").ToString() AndAlso dp2.Rows(k)("DC_CAST_RSN").ToString() = "Process Loss" Then
                    dp1.Rows(i)("ON DATE") = dp2.Rows(k)("ONDT_DUR")
                End If
            Next
        Next
        process.DataSource = dp1
        process.DataBind()

        Dim dm1 As New DataTable()
        dm1.Columns.Add("MECH DELAY REASONS", GetType(String))
        dm1.Columns.Add("ON DATE", GetType(Single))
        dm1.Columns.Add("CUMULATIVE", GetType(Single))
        dm1.Rows.Add("Mold water/spray water", 0.0, 0.0)
        dm1.Rows.Add("Turret problem", 0.0, 0.0)
        dm1.Rows.Add("spray water not matching", 0.0, 0.0)
        dm1.Rows.Add("MLF due to inter roll bulging", 0.0, 0.0)
        dm1.Rows.Add("S/G Hyd. Pressure unhealthy", 0.0, 0.0)
        dm1.Rows.Add("shroud manipulator problem", 0.0, 0.0)
        dm1.Rows.Add("Drive current high", 0.0, 0.0)
        dm1.Rows.Add("others", 0.0, 0.0)
        For i As Integer = 0 To dm1.Rows.Count - 1
            Dim j As Integer = 0
            For j = 0 To dp.Rows.Count - 1
                If dp.Rows(j)("SDC_CAST_RSN").ToString() = dm1.Rows(i)("MECH DELAY REASONS").ToString() AndAlso dp.Rows(j)("DC_CAST_RSN").ToString() = "MECH Dealy" Then
                    dm1.Rows(i)("CUMULATIVE") = dp.Rows(j)("TODT_DUR")
                End If
            Next
            Dim k As Integer = 0
            For k = 0 To dp2.Rows.Count - 1
                If dp2.Rows(k)("SDC_CAST_RSN").ToString() = dm1.Rows(i)("MECH DELAY REASONS").ToString() AndAlso dp2.Rows(k)("DC_CAST_RSN").ToString() = "MECH Dealy" Then
                    dm1.Rows(i)("ON DATE") = dp2.Rows(k)("ONDT_DUR")
                End If
            Next
        Next
        mech.DataSource = dm1
        mech.DataBind()

        Dim di1 As New DataTable()
        di1.Columns.Add("IEM DELAY REASONS", GetType(String))
        di1.Columns.Add("ON DATE", GetType(Single))
        di1.Columns.Add("CUMULATIVE", GetType(Single))
        di1.Rows.Add("RAM Problem", 0.0, 0.0)
        di1.Rows.Add("Drive current high", 0.0, 0.0)
        di1.Rows.Add("TCM", 0.0, 0.0)
        di1.Rows.Add("SMM", 0.0, 0.0)
        di1.Rows.Add("Roller Table", 0.0, 0.0)
        di1.Rows.Add("Temperature Problem", 0.0, 0.0)
        di1.Rows.Add("FCV(spary water) malfunctioning", 0.0, 0.0)
        di1.Rows.Add("CT Bed problem", 0.0, 0.0)
        di1.Rows.Add("Crane Delay", 0.0, 0.0)
        di1.Rows.Add("POWER DIP", 0.0, 0.0)
        di1.Rows.Add("BDS not working", 0.0, 0.0)
        di1.Rows.Add("others", 0.0, 0.0)
        For i As Integer = 0 To di1.Rows.Count - 1
            Dim j As Integer = 0
            For j = 0 To dp.Rows.Count - 1
                If dp.Rows(j)("SDC_CAST_RSN").ToString() = di1.Rows(i)("IEM DELAY REASONS").ToString() AndAlso dp.Rows(j)("DC_CAST_RSN").ToString() = "IEM Delay" Then
                    di1.Rows(i)("CUMULATIVE") = dp.Rows(j)("TODT_DUR")
                End If
            Next
            Dim k As Integer = 0
            For k = 0 To dp2.Rows.Count - 1
                If dp2.Rows(k)("SDC_CAST_RSN").ToString() = di1.Rows(i)("IEM DELAY REASONS").ToString() AndAlso dp2.Rows(k)("DC_CAST_RSN").ToString() = "IEM Delay" Then
                    di1.Rows(i)("ON DATE") = dp2.Rows(k)("ONDT_DUR")
                End If
            Next
        Next
        iem.DataSource = di1
        iem.DataBind()

        Dim dh1 As New DataTable()
        dh1.Columns.Add("HIGH SUPERHEAT DELAY REASONS", GetType(String))
        dh1.Columns.Add("ON DATE", GetType(Single))
        dh1.Columns.Add("CUMULATIVE", GetType(Single))
        dh1.Rows.Add("High 'S'", 0.0, 0.0)
        dh1.Rows.Add("High Superheat from LF1", 0.0, 0.0)
        dh1.Rows.Add("High Superheat from LF2", 0.0, 0.0)
        dh1.Rows.Add("High Superheat from OLP", 0.0, 0.0)
        dh1.Rows.Add("High Superheat from RH", 0.0, 0.0)
        dh1.Rows.Add("LNC(Ladle Nozzle Choke", 0.0, 0.0)
        dh1.Rows.Add("NFO(No Free Opening) Ladle", 0.0, 0.0)
        dh1.Rows.Add("Others", 0.0, 0.0)
        For i As Integer = 0 To dh1.Rows.Count - 1
            Dim j As Integer = 0
            For j = 0 To dp.Rows.Count - 1
                If dp.Rows(j)("SDC_CAST_RSN").ToString() = dh1.Rows(i)("HIGH SUPERHEAT DELAY REASONS").ToString() AndAlso dp.Rows(j)("DC_CAST_RSN").ToString() = "High Super Heat" Then
                    dh1.Rows(i)("CUMULATIVE") = dp.Rows(j)("TODT_DUR")
                End If
            Next
            Dim k As Integer = 0
            For k = 0 To dp2.Rows.Count - 1
                If dp2.Rows(k)("SDC_CAST_RSN").ToString() = dh1.Rows(i)("HIGH SUPERHEAT DELAY REASONS").ToString() AndAlso dp2.Rows(k)("DC_CAST_RSN").ToString() = "High Super Heat" Then
                    dh1.Rows(i)("ON DATE") = dp2.Rows(k)("ONDT_DUR")
                End If
            Next
        Next
        hsh.DataSource = dh1
        hsh.DataBind()

        Dim da1 As New DataTable()
        da1.Columns.Add("DELAY HEAT ARRIVAL REASONS", GetType(String))
        da1.Columns.Add("ON DATE", GetType(Single))
        da1.Columns.Add("CUMULATIVE", GetType(Single))
        da1.Rows.Add("LF1 Delay", 0.0, 0.0)
        da1.Rows.Add("LF2 Delay", 0.0, 0.0)
        da1.Rows.Add("OLP Delay", 0.0, 0.0)
        da1.Rows.Add("RH Problem", 0.0, 0.0)
        For i As Integer = 0 To da1.Rows.Count - 1
            Dim j As Integer = 0
            For j = 0 To dp.Rows.Count - 1
                If dp.Rows(j)("SDC_CAST_RSN").ToString() = da1.Rows(i)("DELAY HEAT ARRIVAL REASONS").ToString() AndAlso dp.Rows(j)("DC_CAST_RSN").ToString() = "Delay Heat Arrival" Then
                    da1.Rows(i)("CUMULATIVE") = dp.Rows(j)("TODT_DUR")
                End If
            Next
            Dim k As Integer = 0
            For k = 0 To dp2.Rows.Count - 1
                If dp2.Rows(k)("SDC_CAST_RSN").ToString() = da1.Rows(i)("DELAY HEAT ARRIVAL REASONS").ToString() AndAlso dp2.Rows(k)("DC_CAST_RSN").ToString() = "Delay Heat Arrival" Then
                    da1.Rows(i)("ON DATE") = dp2.Rows(k)("ONDT_DUR")
                End If
            Next
        Next
        dha.DataSource = da1
        dha.DataBind()

        Dim dc1 As New DataTable()
        dc1.Columns.Add("CASTER OPERATION DELAY REASONS", GetType(String))
        dc1.Columns.Add("ON DATE", GetType(Single))
        dc1.Columns.Add("CUMULATIVE", GetType(Single))
        dc1.Rows.Add("Abnormal Sticky Behavior", 0.0, 0.0)
        dc1.Rows.Add("Flushimg", 0.0, 0.0)
        dc1.Rows.Add("LTS", 0.0, 0.0)
        dc1.Rows.Add("others", 0.0, 0.0)
        dc1.Rows.Add("Shroud cleaning", 0.0, 0.0)
        dc1.Rows.Add("Sticker/Crack", 0.0, 0.0)
        dc1.Rows.Add("Cutting Problem", 0.0, 0.0)
        dc1.Rows.Add("Level not matching", 0.0, 0.0)
        For i As Integer = 0 To dc1.Rows.Count - 1
            Dim j As Integer = 0
            For j = 0 To dp.Rows.Count - 1
                If dp.Rows(j)("SDC_CAST_RSN").ToString() = dc1.Rows(i)("CASTER OPERATION DELAY REASONS").ToString() AndAlso dp.Rows(j)("DC_CAST_RSN").ToString() = "Caster Operation" Then
                    dc1.Rows(i)("CUMULATIVE") = dp.Rows(j)("TODT_DUR")
                End If
            Next
            Dim k As Integer = 0
            For k = 0 To dp2.Rows.Count - 1
                If dp2.Rows(k)("SDC_CAST_RSN").ToString() = dc1.Rows(i)("CASTER OPERATION DELAY REASONS").ToString() AndAlso dp2.Rows(k)("DC_CAST_RSN").ToString() = "Caster Operation" Then
                    dc1.Rows(i)("ON DATE") = dp2.Rows(k)("ONDT_DUR")
                End If
            Next
        Next
        co.DataSource = dc1
        co.DataBind()
    End Sub

    Protected Sub Clear_Click(ByVal sender As Object, ByVal e As EventArgs)
        grd1.DataSource = Nothing
        grd1.DataBind()
        grd2.DataSource = Nothing
        grd2.DataBind()
        G1.DataSource = Nothing
        G1.DataBind()
        G2.DataSource = Nothing
        G2.DataBind()
        G3.DataSource = Nothing
        G3.DataBind()
        G4.DataSource = Nothing
        G4.DataBind()
        G5.DataSource = Nothing
        G5.DataBind()
        G6.DataSource = Nothing
        G6.DataBind()
        process.DataSource = Nothing
        process.DataBind()
        mech.DataSource = Nothing
        mech.DataBind()
        iem.DataSource = Nothing
        iem.DataBind()
        hsh.DataSource = Nothing
        hsh.DataBind()
        dha.DataSource = Nothing
        dha.DataBind()
        co.DataSource = Nothing
        co.DataBind()
        Dim dt As New DataTable()
        dt.Columns.Add("CASTER", GetType(String))
        dt.Columns.Add("ON_DATE_SPEED", GetType(String))
        dt.Columns.Add("CUMULATIVE SPEED", GetType(String))
        dt.Rows.Add(" ", " ", " ")
        dt.Rows.Add(" ", " ", " ")
        dt.Rows.Add(" ", " ", " ")
        dt.Rows.Add("Avg speed", " ", " ")
        grd3.DataSource = dt
        grd3.DataBind()

        Dim d1 As New DataTable()
        d1.Columns.Add("PROCESS LOSS DELAY REASONS", GetType(String))
        d1.Columns.Add("ON DATE", GetType(String))
        d1.Columns.Add("CUMULATIVE", GetType(String))
        d1.Rows.Add("CAP OFF/Shut down", " ", " ")
        d1.Rows.Add("Caster Start Ramping", " ", " ")
        d1.Rows.Add("FTC:Planned", " ", " ")
        d1.Rows.Add("HSH DURE TO MAIN/ETC", " ", " ")
        d1.Rows.Add("RESTRICTED TPUT DUE TO QUALITY", " ", " ")
        d1.Rows.Add("Ramming", " ", " ")
        d1.Rows.Add("SEN Lance:Planned", " ", " ")
        d1.Rows.Add("shroud change", " ", " ")
        d1.Rows.Add("SEN Lance:Operation", " ", " ")
        d1.Rows.Add("Transition Metal", " ", " ")
        d1.Rows.Add("Tube Change: Operation", " ", " ")
        d1.Rows.Add("Tube change: Planned", " ", " ")
        d1.Rows.Add("Others", " ", " ")
        G1.DataSource = d1
        G1.DataBind()

        Dim d2 As New DataTable()
        d2.Columns.Add("MECH DELAY REASONS", GetType(String))
        d2.Columns.Add("ON DATE", GetType(String))
        d2.Columns.Add("CUMULATIVE", GetType(String))
        d2.Rows.Add("Mold water/spray water", " ", " ")
        d2.Rows.Add("Turret problem", " ", " ")
        d2.Rows.Add("spray water not matching", " ", " ")
        d2.Rows.Add("MLF due to inter roll bulging", " ", " ")
        d2.Rows.Add("S/G Hyd. Pressure unhealthy", " ", " ")
        d2.Rows.Add("shroud manipulator problem", " ", " ")
        d2.Rows.Add("Drive current high", " ", "  ")
        d2.Rows.Add("others", " ", " ")
        G2.DataSource = d2
        G2.DataBind()

        Dim d3 As New DataTable()
        d3.Columns.Add("IEM DELAY REASONS", GetType(String))
        d3.Columns.Add("ON DATE", GetType(String))
        d3.Columns.Add("CUMULATIVE", GetType(String))
        d3.Rows.Add("RAM Problem", " ", " ")
        d3.Rows.Add("Drive current high", " ", " ")
        d3.Rows.Add("TCM", " ", " ")
        d3.Rows.Add("SMM", " ", " ")
        d3.Rows.Add("Roller Table", " ", " ")
        d3.Rows.Add("Temperature Problem", " ", " ")
        d3.Rows.Add("FCV(spary water) malfunctioning", " ", " ")
        d3.Rows.Add("CT Bed problem", " ", " ")
        d3.Rows.Add("Crane Delay", " ", " ")
        d3.Rows.Add("POWER DIP", " ", " ")
        d3.Rows.Add("BDS not working", " ", " ")
        d3.Rows.Add("others", " ", " ")
        G3.DataSource = d3
        G3.DataBind()

        Dim d4 As New DataTable()
        d4.Columns.Add("HIGH SUPERHEAT DELAY REASONS", GetType(String))
        d4.Columns.Add("ON DATE", GetType(String))
        d4.Columns.Add("CUMULATIVE", GetType(String))
        d4.Rows.Add("High 'S'", " ", " ")
        d4.Rows.Add("High Superheat from LF1", " ", " ")
        d4.Rows.Add("High Superheat from LF2", " ", " ")
        d4.Rows.Add("High Superheat from OLP", " ", " ")
        d4.Rows.Add("High Superheat from RH", " ", " ")
        d4.Rows.Add("LNC(Ladle Nozzle Choke", " ", " ")
        d4.Rows.Add("NFO(No Free Opening) Ladle", " ", " ")
        d4.Rows.Add("Others", " ", " ")
        G4.DataSource = d4
        G4.DataBind()

        Dim d5 As New DataTable()
        d5.Columns.Add("DELAY HEAT ARRIVAL REASONS", GetType(String))
        d5.Columns.Add("ON DATE", GetType(String))
        d5.Columns.Add("CUMULATIVE", GetType(String))
        d5.Rows.Add("LF1 Delay", " ", " ")
        d5.Rows.Add("LF2 Delay", " ", " ")
        d5.Rows.Add("OLP Delay", " ", " ")
        d5.Rows.Add("RH Problem", " ", " ")
        G5.DataSource = d5
        G5.DataBind()

        Dim d6 As New DataTable()
        d6.Columns.Add("CASTER OPERATION DELAY REASONS", GetType(String))
        d6.Columns.Add("ON DATE", GetType(String))
        d6.Columns.Add("CUMULATIVE", GetType(String))
        d6.Rows.Add("Abnormal Sticky Behavior", " ", " ")
        d6.Rows.Add("Flushimg", " ", " ")
        d6.Rows.Add("LTS", " ", " ")
        d6.Rows.Add("others", " ", " ")
        d6.Rows.Add("Shroud cleaning", " ", " ")
        d6.Rows.Add("Sticker/Crack", " ", " ")
        d6.Rows.Add("Cutting Problem", " ", " ")
        d6.Rows.Add("Level not matching", " ", " ")
        G6.DataSource = d6
        G6.DataBind()
    End Sub
End Class
