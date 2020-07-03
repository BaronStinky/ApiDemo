using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTechDemo.Models
{
    public class JobSearchModel
    {
        public Total total { get; set; }
        public int positions { get; set; }
        public int query_time_in_millis { get; set; }
        public int result_time_in_millis { get; set; }
        public object[] stats { get; set; }
        public Hit[] hits { get; set; }
    }

    public class Total
    {
        public int value { get; set; }
    }


    public class Hit
    { 
        public string[] location { get; set; }
        public float relevance { get; set; }
        public string id { get; set; }
        public string external_id { get; set; }
        public string webpage_url { get; set; }
        public string logo_url { get; set; }
        public string headline { get; set; }
        public DateTime application_deadline { get; set; }
        public int number_of_vacancies { get; set; }
        public Description description { get; set; }
        public Employment_Type employment_type { get; set; }
        public Salary_Type salary_type { get; set; }
        public string salary_description { get; set; }
        public Duration duration { get; set; }
        public Working_Hours_Type working_hours_type { get; set; }
        public Scope_Of_Work scope_of_work { get; set; }
        public object access { get; set; }
        public Employer employer { get; set; }
        public Application_Details application_details { get; set; }
        public bool experience_required { get; set; }
        public bool access_to_own_car { get; set; }
        public bool driving_license_required { get; set; }
        public Driving_License[] driving_license { get; set; }
        public Occupation occupation { get; set; }
        public Occupation_Group occupation_group { get; set; }
        public Occupation_Field occupation_field { get; set; }
        public Workplace_Address workplace_address { get; set; }
        public Must_Have must_have { get; set; }
        public Nice_To_Have nice_to_have { get; set; }
        public DateTime publication_date { get; set; }
        public DateTime last_publication_date { get; set; }
        public bool removed { get; set; }
        public object removed_date { get; set; }
        public string source_type { get; set; }
        public long timestamp { get; set; }
    }

    public class Description
    {
        public string text { get; set; }
        public string text_formatted { get; set; }
        public object company_information { get; set; }
        public object needs { get; set; }
        public object requirements { get; set; }
        public string conditions { get; set; }
    }

    public class Employment_Type
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Salary_Type
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Duration
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Working_Hours_Type
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Scope_Of_Work
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Employer
    {
        public object phone_number { get; set; }
        public object email { get; set; }
        public string url { get; set; }
        public string organization_number { get; set; }
        public string name { get; set; }
        public string workplace { get; set; }
    }

    public class Application_Details
    {
        public object information { get; set; }
        public string reference { get; set; }
        public string email { get; set; }
        public bool via_af { get; set; }
        public string url { get; set; }
        public object other { get; set; }
    }

    public class Occupation
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Occupation_Group
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Occupation_Field
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Workplace_Address
    {
        public string municipality { get; set; }
        public string municipality_code { get; set; }
        public string municipality_concept_id { get; set; }
        public string region { get; set; }
        public string region_code { get; set; }
        public string region_concept_id { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string country_concept_id { get; set; }
        public string street_address { get; set; }
        public string postcode { get; set; }
        public string city { get; set; }
        public float[] coordinates { get; set; }
    }

    public class Must_Have
    {
        public object[] skills { get; set; }
        public object[] languages { get; set; }
        public Work_Experiences[] work_experiences { get; set; }
    }

    public class Work_Experiences
    {
        public int weight { get; set; }
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Nice_To_Have
    {
        public object[] skills { get; set; }
        public object[] languages { get; set; }
        public Work_Experiences1[] work_experiences { get; set; }
    }

    public class Work_Experiences1
    {
        public int weight { get; set; }
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

    public class Driving_License
    {
        public string concept_id { get; set; }
        public string label { get; set; }
        public string legacy_ams_taxonomy_id { get; set; }
    }

}
