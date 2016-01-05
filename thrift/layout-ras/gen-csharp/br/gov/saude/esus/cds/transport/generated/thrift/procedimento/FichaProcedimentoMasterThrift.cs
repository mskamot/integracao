/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace br.gov.saude.esus.cds.transport.generated.thrift.procedimento
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class FichaProcedimentoMasterThrift : TBase
  {
    private int _tpCdsOrigem;
    private List<FichaProcedimentoChildThrift> _atendProcedimentos;
    private long _numTotalAfericaoPa;
    private long _numTotalGlicemiaCapilar;
    private long _numTotalAfericaoTemperatura;
    private long _numTotalMedicaoAltura;
    private long _numTotalCurativoSimples;
    private long _numTotalMedicaoPeso;
    private long _numTotalColetaMaterialParaExameLaboratorial;

    public string UuidFicha { get; set; }

    public int TpCdsOrigem
    {
      get
      {
        return _tpCdsOrigem;
      }
      set
      {
        __isset.tpCdsOrigem = true;
        this._tpCdsOrigem = value;
      }
    }

    public br.gov.saude.esus.cds.transport.generated.thrift.common.UnicaLotacaoHeaderThrift HeaderTransport { get; set; }

    public List<FichaProcedimentoChildThrift> AtendProcedimentos
    {
      get
      {
        return _atendProcedimentos;
      }
      set
      {
        __isset.atendProcedimentos = true;
        this._atendProcedimentos = value;
      }
    }

    public long NumTotalAfericaoPa
    {
      get
      {
        return _numTotalAfericaoPa;
      }
      set
      {
        __isset.numTotalAfericaoPa = true;
        this._numTotalAfericaoPa = value;
      }
    }

    public long NumTotalGlicemiaCapilar
    {
      get
      {
        return _numTotalGlicemiaCapilar;
      }
      set
      {
        __isset.numTotalGlicemiaCapilar = true;
        this._numTotalGlicemiaCapilar = value;
      }
    }

    public long NumTotalAfericaoTemperatura
    {
      get
      {
        return _numTotalAfericaoTemperatura;
      }
      set
      {
        __isset.numTotalAfericaoTemperatura = true;
        this._numTotalAfericaoTemperatura = value;
      }
    }

    public long NumTotalMedicaoAltura
    {
      get
      {
        return _numTotalMedicaoAltura;
      }
      set
      {
        __isset.numTotalMedicaoAltura = true;
        this._numTotalMedicaoAltura = value;
      }
    }

    public long NumTotalCurativoSimples
    {
      get
      {
        return _numTotalCurativoSimples;
      }
      set
      {
        __isset.numTotalCurativoSimples = true;
        this._numTotalCurativoSimples = value;
      }
    }

    public long NumTotalMedicaoPeso
    {
      get
      {
        return _numTotalMedicaoPeso;
      }
      set
      {
        __isset.numTotalMedicaoPeso = true;
        this._numTotalMedicaoPeso = value;
      }
    }

    public long NumTotalColetaMaterialParaExameLaboratorial
    {
      get
      {
        return _numTotalColetaMaterialParaExameLaboratorial;
      }
      set
      {
        __isset.numTotalColetaMaterialParaExameLaboratorial = true;
        this._numTotalColetaMaterialParaExameLaboratorial = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool tpCdsOrigem;
      public bool atendProcedimentos;
      public bool numTotalAfericaoPa;
      public bool numTotalGlicemiaCapilar;
      public bool numTotalAfericaoTemperatura;
      public bool numTotalMedicaoAltura;
      public bool numTotalCurativoSimples;
      public bool numTotalMedicaoPeso;
      public bool numTotalColetaMaterialParaExameLaboratorial;
    }

    public FichaProcedimentoMasterThrift() {
    }

    public FichaProcedimentoMasterThrift(string uuidFicha, br.gov.saude.esus.cds.transport.generated.thrift.common.UnicaLotacaoHeaderThrift headerTransport) : this() {
      this.UuidFicha = uuidFicha;
      this.HeaderTransport = headerTransport;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_uuidFicha = false;
      bool isset_headerTransport = false;
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              UuidFicha = iprot.ReadString();
              isset_uuidFicha = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              TpCdsOrigem = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              HeaderTransport = new br.gov.saude.esus.cds.transport.generated.thrift.common.UnicaLotacaoHeaderThrift();
              HeaderTransport.Read(iprot);
              isset_headerTransport = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                AtendProcedimentos = new List<FichaProcedimentoChildThrift>();
                TList _list8 = iprot.ReadListBegin();
                for( int _i9 = 0; _i9 < _list8.Count; ++_i9)
                {
                  FichaProcedimentoChildThrift _elem10;
                  _elem10 = new FichaProcedimentoChildThrift();
                  _elem10.Read(iprot);
                  AtendProcedimentos.Add(_elem10);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I64) {
              NumTotalAfericaoPa = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I64) {
              NumTotalGlicemiaCapilar = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I64) {
              NumTotalAfericaoTemperatura = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I64) {
              NumTotalMedicaoAltura = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I64) {
              NumTotalCurativoSimples = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I64) {
              NumTotalMedicaoPeso = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I64) {
              NumTotalColetaMaterialParaExameLaboratorial = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
      if (!isset_uuidFicha)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      if (!isset_headerTransport)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("FichaProcedimentoMasterThrift");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "uuidFicha";
      field.Type = TType.String;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(UuidFicha);
      oprot.WriteFieldEnd();
      if (__isset.tpCdsOrigem) {
        field.Name = "tpCdsOrigem";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TpCdsOrigem);
        oprot.WriteFieldEnd();
      }
      field.Name = "headerTransport";
      field.Type = TType.Struct;
      field.ID = 3;
      oprot.WriteFieldBegin(field);
      HeaderTransport.Write(oprot);
      oprot.WriteFieldEnd();
      if (AtendProcedimentos != null && __isset.atendProcedimentos) {
        field.Name = "atendProcedimentos";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, AtendProcedimentos.Count));
          foreach (FichaProcedimentoChildThrift _iter11 in AtendProcedimentos)
          {
            _iter11.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.numTotalAfericaoPa) {
        field.Name = "numTotalAfericaoPa";
        field.Type = TType.I64;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(NumTotalAfericaoPa);
        oprot.WriteFieldEnd();
      }
      if (__isset.numTotalGlicemiaCapilar) {
        field.Name = "numTotalGlicemiaCapilar";
        field.Type = TType.I64;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(NumTotalGlicemiaCapilar);
        oprot.WriteFieldEnd();
      }
      if (__isset.numTotalAfericaoTemperatura) {
        field.Name = "numTotalAfericaoTemperatura";
        field.Type = TType.I64;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(NumTotalAfericaoTemperatura);
        oprot.WriteFieldEnd();
      }
      if (__isset.numTotalMedicaoAltura) {
        field.Name = "numTotalMedicaoAltura";
        field.Type = TType.I64;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(NumTotalMedicaoAltura);
        oprot.WriteFieldEnd();
      }
      if (__isset.numTotalCurativoSimples) {
        field.Name = "numTotalCurativoSimples";
        field.Type = TType.I64;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(NumTotalCurativoSimples);
        oprot.WriteFieldEnd();
      }
      if (__isset.numTotalMedicaoPeso) {
        field.Name = "numTotalMedicaoPeso";
        field.Type = TType.I64;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(NumTotalMedicaoPeso);
        oprot.WriteFieldEnd();
      }
      if (__isset.numTotalColetaMaterialParaExameLaboratorial) {
        field.Name = "numTotalColetaMaterialParaExameLaboratorial";
        field.Type = TType.I64;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(NumTotalColetaMaterialParaExameLaboratorial);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("FichaProcedimentoMasterThrift(");
      __sb.Append(", UuidFicha: ");
      __sb.Append(UuidFicha);
      if (__isset.tpCdsOrigem) {
        __sb.Append(", TpCdsOrigem: ");
        __sb.Append(TpCdsOrigem);
      }
      __sb.Append(", HeaderTransport: ");
      __sb.Append(HeaderTransport== null ? "<null>" : HeaderTransport.ToString());
      if (AtendProcedimentos != null && __isset.atendProcedimentos) {
        __sb.Append(", AtendProcedimentos: ");
        __sb.Append(AtendProcedimentos);
      }
      if (__isset.numTotalAfericaoPa) {
        __sb.Append(", NumTotalAfericaoPa: ");
        __sb.Append(NumTotalAfericaoPa);
      }
      if (__isset.numTotalGlicemiaCapilar) {
        __sb.Append(", NumTotalGlicemiaCapilar: ");
        __sb.Append(NumTotalGlicemiaCapilar);
      }
      if (__isset.numTotalAfericaoTemperatura) {
        __sb.Append(", NumTotalAfericaoTemperatura: ");
        __sb.Append(NumTotalAfericaoTemperatura);
      }
      if (__isset.numTotalMedicaoAltura) {
        __sb.Append(", NumTotalMedicaoAltura: ");
        __sb.Append(NumTotalMedicaoAltura);
      }
      if (__isset.numTotalCurativoSimples) {
        __sb.Append(", NumTotalCurativoSimples: ");
        __sb.Append(NumTotalCurativoSimples);
      }
      if (__isset.numTotalMedicaoPeso) {
        __sb.Append(", NumTotalMedicaoPeso: ");
        __sb.Append(NumTotalMedicaoPeso);
      }
      if (__isset.numTotalColetaMaterialParaExameLaboratorial) {
        __sb.Append(", NumTotalColetaMaterialParaExameLaboratorial: ");
        __sb.Append(NumTotalColetaMaterialParaExameLaboratorial);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
