package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.model.DemandShift;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * Preferred demand for a certain skill and for a specific block during the day.
 */
@ApiModel(description = "Preferred demand for a certain skill and for a specific block during the day.")
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class Demand   {
  @JsonProperty("shift")
  private DemandShift shift = null;

  @JsonProperty("skill")
  private String skill = null;

  @JsonProperty("prefDemand")
  private Integer prefDemand = null;

  public Demand shift(DemandShift shift) {
    this.shift = shift;
    return this;
  }

  /**
   * Get shift
   * @return shift
  **/
  @ApiModelProperty(required = true, value = "")
  @NotNull

  @Valid
  public DemandShift getShift() {
    return shift;
  }

  public void setShift(DemandShift shift) {
    this.shift = shift;
  }

  public Demand skill(String skill) {
    this.skill = skill;
    return this;
  }

  /**
   * Skill type definition
   * @return skill
  **/
  @ApiModelProperty(required = true, value = "Skill type definition")
  @NotNull

  public String getSkill() {
    return skill;
  }

  public void setSkill(String skill) {
    this.skill = skill;
  }

  public Demand prefDemand(Integer prefDemand) {
    this.prefDemand = prefDemand;
    return this;
  }

  /**
   * The number of employees of that skill to be present.
   * @return prefDemand
  **/
  @ApiModelProperty(required = true, value = "The number of employees of that skill to be present.")
  @NotNull

  public Integer getPrefDemand() {
    return prefDemand;
  }

  public void setPrefDemand(Integer prefDemand) {
    this.prefDemand = prefDemand;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Demand demand = (Demand) o;
    return Objects.equals(this.shift, demand.shift) &&
        Objects.equals(this.skill, demand.skill) &&
        Objects.equals(this.prefDemand, demand.prefDemand);
  }

  @Override
  public int hashCode() {
    return Objects.hash(shift, skill, prefDemand);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Demand {\n");
    
    sb.append("    shift: ").append(toIndentedString(shift)).append("\n");
    sb.append("    skill: ").append(toIndentedString(skill)).append("\n");
    sb.append("    prefDemand: ").append(toIndentedString(prefDemand)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
}
