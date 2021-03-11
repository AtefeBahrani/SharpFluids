

using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnitsNet;

public class AbstractState : IDisposable
{

    public HandleRef swigCPtr;
    public bool swigCMemOwn;


    internal AbstractState()
    {

    }


    internal AbstractState(IntPtr cPtr, bool cMemoryOwn)
    {
        swigCMemOwn = cMemoryOwn;
        swigCPtr = new HandleRef(this, cPtr);
    }


    //internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AbstractState obj)
    //{
    //    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    //}

    ~AbstractState()
    {
        Dispose();
    }

    public virtual void Dispose()
    {
        lock (this)
        {
            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                swigCMemOwn = false;
                if (Environment.Is64BitProcess)
                    CoolPropPINVOKE64.delete_AbstractState(swigCPtr);
                else
                    CoolPropPINVOKE.delete_AbstractState(swigCPtr);

                swigCPtr = new HandleRef(null, IntPtr.Zero);
            }
            GC.SuppressFinalize(this);
        }
    }

    public static AbstractState factory(string backend, string fluid_names)
    {

        if (Environment.Is64BitProcess)
        {
            IntPtr cPtr = CoolPropPINVOKE64.AbstractState_factory__SWIG_0(backend, fluid_names);
            AbstractState ret = (cPtr == IntPtr.Zero) ? null : new AbstractState(cPtr, false);
            if (CoolPropPINVOKE64.SWIGPendingException.Pending) throw CoolPropPINVOKE64.SWIGPendingException.Retrieve();
            return ret;
        }
        else
        {
            IntPtr cPtr = CoolPropPINVOKE.AbstractState_factory__SWIG_0(backend, fluid_names);
            AbstractState ret = (cPtr == IntPtr.Zero) ? null : new AbstractState(cPtr, false);
            if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
            return ret;

        }


    }

    //public static AbstractState factory(string backend, StringVector fluid_names) {
    //  global::System.IntPtr cPtr = CoolPropPINVOKE.AbstractState_factory__SWIG_1(backend, StringVector.getCPtr(fluid_names));
    //  AbstractState ret = (cPtr == global::System.IntPtr.Zero) ? null : new AbstractState(cPtr, false);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public void set_T(double T) {
    //  CoolPropPINVOKE.AbstractState_set_T(swigCPtr, T);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    public virtual string backend_name()
    {

        if (Environment.Is64BitProcess)
        {
            string ret = CoolPropPINVOKE64.AbstractState_backend_name(swigCPtr);
            if (CoolPropPINVOKE64.SWIGPendingException.Pending) throw CoolPropPINVOKE64.SWIGPendingException.Retrieve();
            return ret;
        }
        else
        {
            string ret = CoolPropPINVOKE.AbstractState_backend_name(swigCPtr);
            if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }


    }

    //public virtual bool using_mole_fractions() {
    //  bool ret = CoolPropPINVOKE.AbstractState_using_mole_fractions(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public virtual bool using_mass_fractions()
    {

        if (Environment.Is64BitProcess)
        {
            bool ret = CoolPropPINVOKE64.AbstractState_using_mass_fractions(swigCPtr);
            //if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }
        else
        {
            bool ret = CoolPropPINVOKE.AbstractState_using_mass_fractions(swigCPtr);
            //if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }




    }

    //public virtual bool using_volu_fractions() {
    //  bool ret = CoolPropPINVOKE.AbstractState_using_volu_fractions(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public virtual void set_reference_stateS(string reference_state) {
    //  CoolPropPINVOKE.AbstractState_set_reference_stateS(swigCPtr, reference_state);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public virtual void set_reference_stateD(double T, double rhomolar, double hmolar0, double smolar0) {
    //  CoolPropPINVOKE.AbstractState_set_reference_stateD(swigCPtr, T, rhomolar, hmolar0, smolar0);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public void set_mole_fractions(DoubleVector mole_fractions) {
    //  CoolPropPINVOKE.AbstractState_set_mole_fractions(swigCPtr, DoubleVector.getCPtr(mole_fractions));
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    public void set_mass_fractions(DoubleVector mass_fractions)
    {

        if (Environment.Is64BitProcess)
        {
            CoolPropPINVOKE64.AbstractState_set_mass_fractions(swigCPtr, DoubleVector.getCPtr(mass_fractions));
            //if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
        }
        else
        {
            CoolPropPINVOKE.AbstractState_set_mass_fractions(swigCPtr, DoubleVector.getCPtr(mass_fractions));
            //if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
        }


    }

    public void set_volu_fractions(DoubleVector volu_fractions)
    {

        if (Environment.Is64BitProcess)
        {
            CoolPropPINVOKE64.AbstractState_set_volu_fractions(swigCPtr, DoubleVector.getCPtr(volu_fractions));
            //if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
        }
        else
        {
            CoolPropPINVOKE.AbstractState_set_volu_fractions(swigCPtr, DoubleVector.getCPtr(volu_fractions));
            //if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
        }


    }

    //public DoubleVector mole_fractions_liquid() {
    //  DoubleVector ret = new DoubleVector(CoolPropPINVOKE.AbstractState_mole_fractions_liquid(swigCPtr), true);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public DoubleVector mole_fractions_vapor() {
    //  DoubleVector ret = new DoubleVector(CoolPropPINVOKE.AbstractState_mole_fractions_vapor(swigCPtr), true);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public virtual SWIGTYPE_p_std__vectorT_CoolPropDbl_t get_mole_fractions() {
    //  SWIGTYPE_p_std__vectorT_CoolPropDbl_t ret = new SWIGTYPE_p_std__vectorT_CoolPropDbl_t(CoolPropPINVOKE.AbstractState_get_mole_fractions(swigCPtr), false);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public virtual SWIGTYPE_p_std__vectorT_CoolPropDbl_t get_mass_fractions() {
    //  SWIGTYPE_p_std__vectorT_CoolPropDbl_t ret = new SWIGTYPE_p_std__vectorT_CoolPropDbl_t(CoolPropPINVOKE.AbstractState_get_mass_fractions(swigCPtr), true);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public virtual void update(input_pairs input_pair, double Value1, double Value2)
    {

        if (Environment.Is64BitProcess)
        {
            CoolPropPINVOKE64.AbstractState_update(swigCPtr, (int)input_pair, Value1, Value2);
            if (CoolPropPINVOKE64.SWIGPendingException.Pending) throw CoolPropPINVOKE64.SWIGPendingException.Retrieve();
        }
        else
        {
            CoolPropPINVOKE.AbstractState_update(swigCPtr, (int)input_pair, Value1, Value2);
            if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
        }

       
    }

    //public virtual void update_with_guesses(input_pairs input_pair, double Value1, double Value2, GuessesStructure guesses) {
    //  CoolPropPINVOKE.AbstractState_update_with_guesses(swigCPtr, (int)input_pair, Value1, Value2, GuessesStructure.getCPtr(guesses));
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public virtual bool available_in_high_level() {
    //  bool ret = CoolPropPINVOKE.AbstractState_available_in_high_level(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public virtual string fluid_param_string(string arg0) {
    //  string ret = CoolPropPINVOKE.AbstractState_fluid_param_string(swigCPtr, arg0);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public StringVector fluid_names() {
    //  StringVector ret = new StringVector(CoolPropPINVOKE.AbstractState_fluid_names(swigCPtr), true);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public virtual double get_fluid_constant(uint i, parameters param) {
    //  double ret = CoolPropPINVOKE.AbstractState_get_fluid_constant(swigCPtr, i, (int)param);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public virtual void set_binary_interaction_double(string CAS1, string CAS2, string parameter, double value) {
    //  CoolPropPINVOKE.AbstractState_set_binary_interaction_double__SWIG_0(swigCPtr, CAS1, CAS2, parameter, value);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public virtual void set_binary_interaction_double(uint i, uint j, string parameter, double value) {
    //  CoolPropPINVOKE.AbstractState_set_binary_interaction_double__SWIG_1(swigCPtr, i, j, parameter, value);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public virtual void set_binary_interaction_string(string CAS1, string CAS2, string parameter, string value) {
    //  CoolPropPINVOKE.AbstractState_set_binary_interaction_string__SWIG_0(swigCPtr, CAS1, CAS2, parameter, value);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public virtual void set_binary_interaction_string(uint i, uint j, string parameter, string value) {
    //  CoolPropPINVOKE.AbstractState_set_binary_interaction_string__SWIG_1(swigCPtr, i, j, parameter, value);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public virtual double get_binary_interaction_double(string CAS1, string CAS2, string parameter) {
    //  double ret = CoolPropPINVOKE.AbstractState_get_binary_interaction_double__SWIG_0(swigCPtr, CAS1, CAS2, parameter);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public virtual double get_binary_interaction_double(uint i, uint j, string parameter) {
    //  double ret = CoolPropPINVOKE.AbstractState_get_binary_interaction_double__SWIG_1(swigCPtr, i, j, parameter);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public virtual string get_binary_interaction_string(string CAS1, string CAS2, string parameter) {
    //  string ret = CoolPropPINVOKE.AbstractState_get_binary_interaction_string(swigCPtr, CAS1, CAS2, parameter);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public virtual void apply_simple_mixing_rule(uint i, uint j, string model) {
    //  CoolPropPINVOKE.AbstractState_apply_simple_mixing_rule(swigCPtr, i, j, model);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public virtual void set_cubic_alpha_C(uint i, string parameter, double c1, double c2, double c3) {
    //  CoolPropPINVOKE.AbstractState_set_cubic_alpha_C(swigCPtr, i, parameter, c1, c2, c3);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public virtual void set_fluid_parameter_double(uint i, string parameter, double value) {
    //  CoolPropPINVOKE.AbstractState_set_fluid_parameter_double(swigCPtr, i, parameter, value);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public virtual double get_fluid_parameter_double(uint i, string parameter) {
    //  double ret = CoolPropPINVOKE.AbstractState_get_fluid_parameter_double(swigCPtr, i, parameter);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public virtual bool clear()
    //{

    //    if (Environment.Is64BitProcess)
    //    {
    //        bool ret = CoolPropPINVOKE64.AbstractState_clear(swigCPtr);
    //        if (CoolPropPINVOKE64.SWIGPendingException.Pending) throw CoolPropPINVOKE64.SWIGPendingException.Retrieve();
    //        return ret;
    //    }
    //    else
    //    {
    //        bool ret = CoolPropPINVOKE.AbstractState_clear(swigCPtr);
    //        if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //        return ret;
    //    }



    //}

    //public virtual SimpleState get_reducing_state() {
    //  SimpleState ret = new SimpleState(CoolPropPINVOKE.AbstractState_get_reducing_state(swigCPtr), false);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public SimpleState get_state(string state) {
    //  SimpleState ret = new SimpleState(CoolPropPINVOKE.AbstractState_get_state(swigCPtr, state), false);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public Temperature Tmin()
    {
        if (Environment.Is64BitProcess)        
            return Temperature.FromKelvins(CoolPropPINVOKE64.AbstractState_Tmin(swigCPtr));        
        else        
            return Temperature.FromKelvins(CoolPropPINVOKE.AbstractState_Tmin(swigCPtr));      
    }

    public Temperature Tmax()
    {
        if (Environment.Is64BitProcess)        
            return Temperature.FromKelvins(CoolPropPINVOKE64.AbstractState_Tmax(swigCPtr));        
        else        
            return Temperature.FromKelvins(CoolPropPINVOKE.AbstractState_Tmax(swigCPtr));
    }

    public Pressure pmax()
    {
        if (Environment.Is64BitProcess)        
            return Pressure.FromPascals(CoolPropPINVOKE64.AbstractState_pmax(swigCPtr));
        else        
            return Pressure.FromPascals(CoolPropPINVOKE.AbstractState_pmax(swigCPtr));        
    }

    //public Temperature Ttriple()
    //{
    //    if (Environment.Is64BitProcess)        
    //        return Temperature.FromKelvins(CoolPropPINVOKE64.AbstractState_Ttriple(swigCPtr));
    //    else        
    //        return Temperature.FromKelvins(CoolPropPINVOKE.AbstractState_Ttriple(swigCPtr));        
    //}

    //public phases phase() {
    //  phases ret = (phases)CoolPropPINVOKE.AbstractState_phase(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public void specify_phase(phases phase) {
    //  CoolPropPINVOKE.AbstractState_specify_phase(swigCPtr, (int)phase);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public void unspecify_phase() {
    //  CoolPropPINVOKE.AbstractState_unspecify_phase(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    public Temperature T_critical()
    {
        if (Environment.Is64BitProcess)        
            return Temperature.FromKelvins(CoolPropPINVOKE64.AbstractState_T_critical(swigCPtr));        
        else        
            return Temperature.FromKelvins(CoolPropPINVOKE.AbstractState_T_critical(swigCPtr));      
    }

    public Pressure p_critical()
    {
        if (Environment.Is64BitProcess)        
            return Pressure.FromPascals(CoolPropPINVOKE64.AbstractState_p_critical(swigCPtr));
        else
            return Pressure.FromPascals(CoolPropPINVOKE.AbstractState_p_critical(swigCPtr));        
    }

    //public double rhomolar_critical() {
    //  double ret = CoolPropPINVOKE.AbstractState_rhomolar_critical(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double rhomass_critical() {
    //  double ret = CoolPropPINVOKE.AbstractState_rhomass_critical(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public SWIGTYPE_p_std__vectorT_CoolProp__CriticalState_t all_critical_points() {
    //  SWIGTYPE_p_std__vectorT_CoolProp__CriticalState_t ret = new SWIGTYPE_p_std__vectorT_CoolProp__CriticalState_t(CoolPropPINVOKE.AbstractState_all_critical_points(swigCPtr), true);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public void build_spinodal() {
    //  CoolPropPINVOKE.AbstractState_build_spinodal(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public SpinodalData get_spinodal_data() {
    //  SpinodalData ret = new SpinodalData(CoolPropPINVOKE.AbstractState_get_spinodal_data(swigCPtr), true);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public void criticality_contour_values(SWIGTYPE_p_double L1star, SWIGTYPE_p_double M1star) {
    //  CoolPropPINVOKE.AbstractState_criticality_contour_values(swigCPtr, SWIGTYPE_p_double.getCPtr(L1star), SWIGTYPE_p_double.getCPtr(M1star));
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public double tangent_plane_distance(double T, double p, DoubleVector w, double rhomolar_guess) {
    //  double ret = CoolPropPINVOKE.AbstractState_tangent_plane_distance__SWIG_0(swigCPtr, T, p, DoubleVector.getCPtr(w), rhomolar_guess);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double tangent_plane_distance(double T, double p, DoubleVector w) {
    //  double ret = CoolPropPINVOKE.AbstractState_tangent_plane_distance__SWIG_1(swigCPtr, T, p, DoubleVector.getCPtr(w));
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double T_reducing() {
    //  double ret = CoolPropPINVOKE.AbstractState_T_reducing(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double rhomolar_reducing() {
    //  double ret = CoolPropPINVOKE.AbstractState_rhomolar_reducing(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double rhomass_reducing() {
    //  double ret = CoolPropPINVOKE.AbstractState_rhomass_reducing(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public Pressure p_triple()
    {
        if (Environment.Is64BitProcess)        
            return Pressure.FromPascals(CoolPropPINVOKE64.AbstractState_p_triple(swigCPtr));        
        else        
            return Pressure.FromPascals(CoolPropPINVOKE.AbstractState_p_triple(swigCPtr));
        
    }

    public string name()
    {
        if (Environment.Is64BitProcess)        
            return CoolPropPINVOKE64.AbstractState_name(swigCPtr);
        else        
            return CoolPropPINVOKE.AbstractState_name(swigCPtr);       
    }

    //public double dipole_moment() {
    //  double ret = CoolPropPINVOKE.AbstractState_dipole_moment(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public double keyed_output(parameters key)
    {
        if (Environment.Is64BitProcess)        
            return CoolPropPINVOKE64.AbstractState_keyed_output(swigCPtr, (int)key);
        else        
            return CoolPropPINVOKE.AbstractState_keyed_output(swigCPtr, (int)key);        
    }

    //public double trivial_keyed_output(parameters key) {
    //  double ret = CoolPropPINVOKE.AbstractState_trivial_keyed_output(swigCPtr, (int)key);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double saturated_liquid_keyed_output(parameters key) {
    //  double ret = CoolPropPINVOKE.AbstractState_saturated_liquid_keyed_output(swigCPtr, (int)key);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double saturated_vapor_keyed_output(parameters key) {
    //  double ret = CoolPropPINVOKE.AbstractState_saturated_vapor_keyed_output(swigCPtr, (int)key);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public Temperature T()
    {
        if (Environment.Is64BitProcess)        
            return Temperature.FromKelvins(CoolPropPINVOKE64.AbstractState_T(swigCPtr));
        else        
            return Temperature.FromKelvins(CoolPropPINVOKE.AbstractState_T(swigCPtr));        
    }

    //public double rhomolar() {
    //  double ret = CoolPropPINVOKE.AbstractState_rhomolar(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public Density rhomass()
    {
        if (Environment.Is64BitProcess)        
            return Density.FromKilogramsPerCubicMeter(CoolPropPINVOKE64.AbstractState_rhomass(swigCPtr));
        else        
            return Density.FromKilogramsPerCubicMeter(CoolPropPINVOKE.AbstractState_rhomass(swigCPtr));        
    }

    public Pressure p()
    {
        if (Environment.Is64BitProcess)        
            return Pressure.FromPascals(CoolPropPINVOKE64.AbstractState_p(swigCPtr));
        else        
            return Pressure.FromPascals(CoolPropPINVOKE.AbstractState_p(swigCPtr));        
    }

    public double Q()
    {
        if (Environment.Is64BitProcess)        
            return CoolPropPINVOKE64.AbstractState_Q(swigCPtr);        
        else        
            return CoolPropPINVOKE.AbstractState_Q(swigCPtr);        
    }

    //public double tau() {
    //  double ret = CoolPropPINVOKE.AbstractState_tau(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double delta() {
    //  double ret = CoolPropPINVOKE.AbstractState_delta(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public MolarMass molar_mass()
    {
        if (Environment.Is64BitProcess)        
            return MolarMass.FromKilogramsPerMole(CoolPropPINVOKE64.AbstractState_molar_mass(swigCPtr));
        else        
            return MolarMass.FromKilogramsPerMole(CoolPropPINVOKE.AbstractState_molar_mass(swigCPtr));     
    }

    //public double acentric_factor() {
    //  double ret = CoolPropPINVOKE.AbstractState_acentric_factor(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double gas_constant() {
    //  double ret = CoolPropPINVOKE.AbstractState_gas_constant(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double Bvirial() {
    //  double ret = CoolPropPINVOKE.AbstractState_Bvirial(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double dBvirial_dT() {
    //  double ret = CoolPropPINVOKE.AbstractState_dBvirial_dT(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double Cvirial() {
    //  double ret = CoolPropPINVOKE.AbstractState_Cvirial(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double dCvirial_dT() {
    //  double ret = CoolPropPINVOKE.AbstractState_dCvirial_dT(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}


    public double compressibility_factor()
    {

        if (Environment.Is64BitProcess)        
            return CoolPropPINVOKE64.AbstractState_compressibility_factor(swigCPtr);
        else        
            return CoolPropPINVOKE.AbstractState_compressibility_factor(swigCPtr);        
    }


    //public double hmolar() {
    //  double ret = CoolPropPINVOKE.AbstractState_hmolar(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public SpecificEnergy hmass()
    {
        if (Environment.Is64BitProcess)        
            return SpecificEnergy.FromJoulesPerKilogram(CoolPropPINVOKE64.AbstractState_hmass(swigCPtr));
        else        
            return SpecificEnergy.FromJoulesPerKilogram(CoolPropPINVOKE.AbstractState_hmass(swigCPtr));        
    }

    //public double hmolar_excess() {
    //  double ret = CoolPropPINVOKE.AbstractState_hmolar_excess(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double hmass_excess() {
    //  double ret = CoolPropPINVOKE.AbstractState_hmass_excess(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double smolar() {
    //  double ret = CoolPropPINVOKE.AbstractState_smolar(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public Entropy smass()
    {
        if (Environment.Is64BitProcess)        
            return Entropy.FromJoulesPerKelvin(CoolPropPINVOKE64.AbstractState_smass(swigCPtr));
        else        
            return Entropy.FromJoulesPerKelvin(CoolPropPINVOKE.AbstractState_smass(swigCPtr));        
    }

    //public double smolar_excess() {
    //  double ret = CoolPropPINVOKE.AbstractState_smolar_excess(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double smass_excess() {
    //  double ret = CoolPropPINVOKE.AbstractState_smass_excess(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double umolar() {
    //  double ret = CoolPropPINVOKE.AbstractState_umolar(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public SpecificEnergy umass()
    {
        if (Environment.Is64BitProcess)        
            return SpecificEnergy.FromJoulesPerKilogram(CoolPropPINVOKE64.AbstractState_umass(swigCPtr));
        else        
            return SpecificEnergy.FromJoulesPerKilogram(CoolPropPINVOKE.AbstractState_umass(swigCPtr));      
    }

    //public double umolar_excess() {
    //  double ret = CoolPropPINVOKE.AbstractState_umolar_excess(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double umass_excess() {
    //  double ret = CoolPropPINVOKE.AbstractState_umass_excess(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double cpmolar() {
    //  double ret = CoolPropPINVOKE.AbstractState_cpmolar(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public SpecificEntropy cpmass()
    {
        if (Environment.Is64BitProcess)        
            return SpecificEntropy.FromJoulesPerKilogramKelvin(CoolPropPINVOKE64.AbstractState_cpmass(swigCPtr));
        else        
            return SpecificEntropy.FromJoulesPerKilogramKelvin(CoolPropPINVOKE.AbstractState_cpmass(swigCPtr));        
    }

    //public double cp0molar() {
    //  double ret = CoolPropPINVOKE.AbstractState_cp0molar(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double cp0mass() {
    //  double ret = CoolPropPINVOKE.AbstractState_cp0mass(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double cvmolar() {
    //  double ret = CoolPropPINVOKE.AbstractState_cvmolar(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public SpecificEntropy cvmass()
    {
        if (Environment.Is64BitProcess)        
            return SpecificEntropy.FromJoulesPerKilogramKelvin(CoolPropPINVOKE64.AbstractState_cvmass(swigCPtr));        
        else        
            return SpecificEntropy.FromJoulesPerKilogramKelvin(CoolPropPINVOKE.AbstractState_cvmass(swigCPtr));        
    }

    //public double gibbsmolar() {
    //  double ret = CoolPropPINVOKE.AbstractState_gibbsmolar(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double gibbsmass() {
    //  double ret = CoolPropPINVOKE.AbstractState_gibbsmass(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double gibbsmolar_excess() {
    //  double ret = CoolPropPINVOKE.AbstractState_gibbsmolar_excess(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double gibbsmass_excess() {
    //  double ret = CoolPropPINVOKE.AbstractState_gibbsmass_excess(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double helmholtzmolar() {
    //  double ret = CoolPropPINVOKE.AbstractState_helmholtzmolar(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double helmholtzmass() {
    //  double ret = CoolPropPINVOKE.AbstractState_helmholtzmass(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double helmholtzmolar_excess() {
    //  double ret = CoolPropPINVOKE.AbstractState_helmholtzmolar_excess(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double helmholtzmass_excess() {
    //  double ret = CoolPropPINVOKE.AbstractState_helmholtzmass_excess(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double volumemolar_excess() {
    //  double ret = CoolPropPINVOKE.AbstractState_volumemolar_excess(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double volumemass_excess() {
    //  double ret = CoolPropPINVOKE.AbstractState_volumemass_excess(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public Speed speed_sound()
    {

        if (Environment.Is64BitProcess)
        {
            if (!(0 <= Q() && Q() <= 1))            
                return Speed.FromMetersPerSecond(CoolPropPINVOKE64.AbstractState_speed_sound(swigCPtr));
        }
        else
        {
            if (!(0 <= Q() && Q() <= 1))            
                return Speed.FromMetersPerSecond(CoolPropPINVOKE.AbstractState_speed_sound(swigCPtr));            
        }

        return Speed.Zero;

    }

    //public double isothermal_compressibility() {
    //  double ret = CoolPropPINVOKE.AbstractState_isothermal_compressibility(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double isobaric_expansion_coefficient() {
    //  double ret = CoolPropPINVOKE.AbstractState_isobaric_expansion_coefficient(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double fugacity_coefficient(uint i) {
    //  double ret = CoolPropPINVOKE.AbstractState_fugacity_coefficient(swigCPtr, i);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double fugacity(uint i) {
    //  double ret = CoolPropPINVOKE.AbstractState_fugacity(swigCPtr, i);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double chemical_potential(uint i) {
    //  double ret = CoolPropPINVOKE.AbstractState_chemical_potential(swigCPtr, i);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double fundamental_derivative_of_gas_dynamics() {
    //  double ret = CoolPropPINVOKE.AbstractState_fundamental_derivative_of_gas_dynamics(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double PIP() {
    //  double ret = CoolPropPINVOKE.AbstractState_PIP(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public void true_critical_point(SWIGTYPE_p_double T, SWIGTYPE_p_double rho) {
    //  CoolPropPINVOKE.AbstractState_true_critical_point(swigCPtr, SWIGTYPE_p_double.getCPtr(T), SWIGTYPE_p_double.getCPtr(rho));
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public void ideal_curve(string type, DoubleVector T, DoubleVector p) {
    //  CoolPropPINVOKE.AbstractState_ideal_curve(swigCPtr, type, DoubleVector.getCPtr(T), DoubleVector.getCPtr(p));
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public double first_partial_deriv(parameters Of, parameters Wrt, parameters Constant) {
    //  double ret = CoolPropPINVOKE.AbstractState_first_partial_deriv(swigCPtr, (int)Of, (int)Wrt, (int)Constant);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double second_partial_deriv(parameters Of1, parameters Wrt1, parameters Constant1, parameters Wrt2, parameters Constant2) {
    //  double ret = CoolPropPINVOKE.AbstractState_second_partial_deriv(swigCPtr, (int)Of1, (int)Wrt1, (int)Constant1, (int)Wrt2, (int)Constant2);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double first_saturation_deriv(parameters Of1, parameters Wrt1) {
    //  double ret = CoolPropPINVOKE.AbstractState_first_saturation_deriv(swigCPtr, (int)Of1, (int)Wrt1);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double second_saturation_deriv(parameters Of1, parameters Wrt1, parameters Wrt2) {
    //  double ret = CoolPropPINVOKE.AbstractState_second_saturation_deriv(swigCPtr, (int)Of1, (int)Wrt1, (int)Wrt2);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double first_two_phase_deriv(parameters Of, parameters Wrt, parameters Constant) {
    //  double ret = CoolPropPINVOKE.AbstractState_first_two_phase_deriv(swigCPtr, (int)Of, (int)Wrt, (int)Constant);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double second_two_phase_deriv(parameters Of, parameters Wrt1, parameters Constant1, parameters Wrt2, parameters Constant2) {
    //  double ret = CoolPropPINVOKE.AbstractState_second_two_phase_deriv(swigCPtr, (int)Of, (int)Wrt1, (int)Constant1, (int)Wrt2, (int)Constant2);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double first_two_phase_deriv_splined(parameters Of, parameters Wrt, parameters Constant, double x_end) {
    //  double ret = CoolPropPINVOKE.AbstractState_first_two_phase_deriv_splined(swigCPtr, (int)Of, (int)Wrt, (int)Constant, x_end);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public void build_phase_envelope(string type) {
    //  CoolPropPINVOKE.AbstractState_build_phase_envelope__SWIG_0(swigCPtr, type);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public void build_phase_envelope() {
    //  CoolPropPINVOKE.AbstractState_build_phase_envelope__SWIG_1(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public PhaseEnvelopeData get_phase_envelope_data() {
    //  PhaseEnvelopeData ret = new PhaseEnvelopeData(CoolPropPINVOKE.AbstractState_get_phase_envelope_data(swigCPtr), false);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public virtual bool has_melting_line() {
    //  bool ret = CoolPropPINVOKE.AbstractState_has_melting_line(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double melting_line(int param, int given, double value) {
    //  double ret = CoolPropPINVOKE.AbstractState_melting_line(swigCPtr, param, given, value);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double saturation_ancillary(parameters param, int Q, parameters given, double value) {
    //  double ret = CoolPropPINVOKE.AbstractState_saturation_ancillary(swigCPtr, (int)param, Q, (int)given, value);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    public DynamicViscosity viscosity()
    {
        double localVis = 0;

        if (Environment.Is64BitProcess)
            localVis = CoolPropPINVOKE64.AbstractState_viscosity(swigCPtr);
        else
            localVis = CoolPropPINVOKE.AbstractState_viscosity(swigCPtr);


        if (double.IsNaN(localVis))        
            return DynamicViscosity.Zero;
        else
            return DynamicViscosity.FromPascalSeconds(localVis);
    }

    //public void viscosity_contributions(SWIGTYPE_p_CoolPropDbl dilute, SWIGTYPE_p_CoolPropDbl initial_density, SWIGTYPE_p_CoolPropDbl residual, SWIGTYPE_p_CoolPropDbl critical) {
    //  CoolPropPINVOKE.AbstractState_viscosity_contributions(swigCPtr, SWIGTYPE_p_CoolPropDbl.getCPtr(dilute), SWIGTYPE_p_CoolPropDbl.getCPtr(initial_density), SWIGTYPE_p_CoolPropDbl.getCPtr(residual), SWIGTYPE_p_CoolPropDbl.getCPtr(critical));
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    public ThermalConductivity conductivity()
    {

        try
        {
            if (Environment.Is64BitProcess)        
                return ThermalConductivity.FromWattsPerMeterKelvin(CoolPropPINVOKE64.AbstractState_conductivity(swigCPtr));
            else        
                return ThermalConductivity.FromWattsPerMeterKelvin(CoolPropPINVOKE.AbstractState_conductivity(swigCPtr));        

        }
        catch (ArgumentException)
        {
            //NaN error
            return ThermalConductivity.Zero;
        }

    }

    //public void conductivity_contributions(SWIGTYPE_p_CoolPropDbl dilute, SWIGTYPE_p_CoolPropDbl initial_density, SWIGTYPE_p_CoolPropDbl residual, SWIGTYPE_p_CoolPropDbl critical) {
    //  CoolPropPINVOKE.AbstractState_conductivity_contributions(swigCPtr, SWIGTYPE_p_CoolPropDbl.getCPtr(dilute), SWIGTYPE_p_CoolPropDbl.getCPtr(initial_density), SWIGTYPE_p_CoolPropDbl.getCPtr(residual), SWIGTYPE_p_CoolPropDbl.getCPtr(critical));
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    public ForcePerLength surface_tension()
    {

        if (Environment.Is64BitProcess)
        {
            if (0 < Q() && Q() < 1)            
                return ForcePerLength.FromNewtonsPerMeter(CoolPropPINVOKE64.AbstractState_surface_tension(swigCPtr));            
        }
        else
        {
            if (0 < Q() && Q() < 1)            
                return ForcePerLength.FromNewtonsPerMeter(CoolPropPINVOKE.AbstractState_surface_tension(swigCPtr));            
        }


        return ForcePerLength.Zero;
    }

    public double Prandtl()
    {
        double localPrandtl = 0;

        if (Environment.Is64BitProcess)
            localPrandtl = CoolPropPINVOKE64.AbstractState_Prandtl(swigCPtr);
        else
            localPrandtl = CoolPropPINVOKE.AbstractState_Prandtl(swigCPtr);

        if (double.IsNaN(localPrandtl))
            return 0;
        else
            return localPrandtl;
    }

    //public void conformal_state(string reference_fluid, SWIGTYPE_p_CoolPropDbl T, SWIGTYPE_p_CoolPropDbl rhomolar) {
    //  CoolPropPINVOKE.AbstractState_conformal_state(swigCPtr, reference_fluid, SWIGTYPE_p_CoolPropDbl.getCPtr(T), SWIGTYPE_p_CoolPropDbl.getCPtr(rhomolar));
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public void change_EOS(uint i, string EOS_name) {
    //  CoolPropPINVOKE.AbstractState_change_EOS(swigCPtr, i, EOS_name);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //}

    //public double alpha0() {
    //  double ret = CoolPropPINVOKE.AbstractState_alpha0(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double dalpha0_dDelta() {
    //  double ret = CoolPropPINVOKE.AbstractState_dalpha0_dDelta(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double dalpha0_dTau() {
    //  double ret = CoolPropPINVOKE.AbstractState_dalpha0_dTau(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d2alpha0_dDelta2() {
    //  double ret = CoolPropPINVOKE.AbstractState_d2alpha0_dDelta2(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d2alpha0_dDelta_dTau() {
    //  double ret = CoolPropPINVOKE.AbstractState_d2alpha0_dDelta_dTau(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d2alpha0_dTau2() {
    //  double ret = CoolPropPINVOKE.AbstractState_d2alpha0_dTau2(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d3alpha0_dTau3() {
    //  double ret = CoolPropPINVOKE.AbstractState_d3alpha0_dTau3(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d3alpha0_dDelta_dTau2() {
    //  double ret = CoolPropPINVOKE.AbstractState_d3alpha0_dDelta_dTau2(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d3alpha0_dDelta2_dTau() {
    //  double ret = CoolPropPINVOKE.AbstractState_d3alpha0_dDelta2_dTau(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d3alpha0_dDelta3() {
    //  double ret = CoolPropPINVOKE.AbstractState_d3alpha0_dDelta3(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double alphar() {
    //  double ret = CoolPropPINVOKE.AbstractState_alphar(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double dalphar_dDelta() {
    //  double ret = CoolPropPINVOKE.AbstractState_dalphar_dDelta(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double dalphar_dTau() {
    //  double ret = CoolPropPINVOKE.AbstractState_dalphar_dTau(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d2alphar_dDelta2() {
    //  double ret = CoolPropPINVOKE.AbstractState_d2alphar_dDelta2(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d2alphar_dDelta_dTau() {
    //  double ret = CoolPropPINVOKE.AbstractState_d2alphar_dDelta_dTau(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d2alphar_dTau2() {
    //  double ret = CoolPropPINVOKE.AbstractState_d2alphar_dTau2(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d3alphar_dDelta3() {
    //  double ret = CoolPropPINVOKE.AbstractState_d3alphar_dDelta3(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d3alphar_dDelta2_dTau() {
    //  double ret = CoolPropPINVOKE.AbstractState_d3alphar_dDelta2_dTau(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d3alphar_dDelta_dTau2() {
    //  double ret = CoolPropPINVOKE.AbstractState_d3alphar_dDelta_dTau2(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d3alphar_dTau3() {
    //  double ret = CoolPropPINVOKE.AbstractState_d3alphar_dTau3(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d4alphar_dDelta4() {
    //  double ret = CoolPropPINVOKE.AbstractState_d4alphar_dDelta4(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d4alphar_dDelta3_dTau() {
    //  double ret = CoolPropPINVOKE.AbstractState_d4alphar_dDelta3_dTau(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d4alphar_dDelta2_dTau2() {
    //  double ret = CoolPropPINVOKE.AbstractState_d4alphar_dDelta2_dTau2(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d4alphar_dDelta_dTau3() {
    //  double ret = CoolPropPINVOKE.AbstractState_d4alphar_dDelta_dTau3(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

    //public double d4alphar_dTau4() {
    //  double ret = CoolPropPINVOKE.AbstractState_d4alphar_dTau4(swigCPtr);
    //  if (CoolPropPINVOKE.SWIGPendingException.Pending) throw CoolPropPINVOKE.SWIGPendingException.Retrieve();
    //  return ret;
    //}

}
