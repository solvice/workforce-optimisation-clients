package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.math.BigDecimal;
import org.threeten.bp.LocalDate;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * Employee
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class Employee   {
  @JsonProperty("name")
  private String name = null;

  @JsonProperty("statute")
  private String statute = null;

  @JsonProperty("skill")
  private String skill = null;

  @JsonProperty("efficiency")
  private BigDecimal efficiency = null;

  @JsonProperty("hourlyPay")
  private BigDecimal hourlyPay = null;

  @JsonProperty("lastRestDate")
  private LocalDate lastRestDate = null;

  public Employee name(String name) {
    this.name = name;
    return this;
  }

  /**
   * Unique name/id of employee
   * @return name
  **/
  @ApiModelProperty(required = true, value = "Unique name/id of employee")
  @NotNull

  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public Employee statute(String statute) {
    this.statute = statute;
    return this;
  }

  /**
   * Reference to Statute name
   * @return statute
  **/
  @ApiModelProperty(required = true, value = "Reference to Statute name")
  @NotNull

  public String getStatute() {
    return statute;
  }

  public void setStatute(String statute) {
    this.statute = statute;
  }

  public Employee skill(String skill) {
    this.skill = skill;
    return this;
  }

  /**
   * Skill name owned by employee
   * @return skill
  **/
  @ApiModelProperty(required = true, value = "Skill name owned by employee")
  @NotNull

  public String getSkill() {
    return skill;
  }

  public void setSkill(String skill) {
    this.skill = skill;
  }

  public Employee efficiency(BigDecimal efficiency) {
    this.efficiency = efficiency;
    return this;
  }

  /**
   * Efficiency rate of employee. 1.0 is normal and default
   * @return efficiency
  **/
  @ApiModelProperty(value = "Efficiency rate of employee. 1.0 is normal and default")

  @Valid
  public BigDecimal getEfficiency() {
    return efficiency;
  }

  public void setEfficiency(BigDecimal efficiency) {
    this.efficiency = efficiency;
  }

  public Employee hourlyPay(BigDecimal hourlyPay) {
    this.hourlyPay = hourlyPay;
    return this;
  }

  /**
   * Hourly wage/pay for employee. Total costs are minimised by the optimiser.
   * @return hourlyPay
  **/
  @ApiModelProperty(value = "Hourly wage/pay for employee. Total costs are minimised by the optimiser.")

  @Valid
  public BigDecimal getHourlyPay() {
    return hourlyPay;
  }

  public void setHourlyPay(BigDecimal hourlyPay) {
    this.hourlyPay = hourlyPay;
  }

  public Employee lastRestDate(LocalDate lastRestDate) {
    this.lastRestDate = lastRestDate;
    return this;
  }

  /**
   * The last date on which the employee had a rest before the planning period.
   * @return lastRestDate
  **/
  @ApiModelProperty(value = "The last date on which the employee had a rest before the planning period.")

  @Valid
  public LocalDate getLastRestDate() {
    return lastRestDate;
  }

  public void setLastRestDate(LocalDate lastRestDate) {
    this.lastRestDate = lastRestDate;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Employee employee = (Employee) o;
    return Objects.equals(this.name, employee.name) &&
        Objects.equals(this.statute, employee.statute) &&
        Objects.equals(this.skill, employee.skill) &&
        Objects.equals(this.efficiency, employee.efficiency) &&
        Objects.equals(this.hourlyPay, employee.hourlyPay) &&
        Objects.equals(this.lastRestDate, employee.lastRestDate);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, statute, skill, efficiency, hourlyPay, lastRestDate);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Employee {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    statute: ").append(toIndentedString(statute)).append("\n");
    sb.append("    skill: ").append(toIndentedString(skill)).append("\n");
    sb.append("    efficiency: ").append(toIndentedString(efficiency)).append("\n");
    sb.append("    hourlyPay: ").append(toIndentedString(hourlyPay)).append("\n");
    sb.append("    lastRestDate: ").append(toIndentedString(lastRestDate)).append("\n");
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
