package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import org.threeten.bp.LocalDate;
import org.threeten.bp.OffsetDateTime;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * ShiftAssignment
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class ShiftAssignment   {
  @JsonProperty("date")
  private LocalDate date = null;

  @JsonProperty("employee")
  private String employee = null;

  @JsonProperty("skill")
  private String skill = null;

  @JsonProperty("startDateTime")
  private OffsetDateTime startDateTime = null;

  @JsonProperty("endDateTime")
  private OffsetDateTime endDateTime = null;

  @JsonProperty("locked")
  private Boolean locked = null;

  public ShiftAssignment date(LocalDate date) {
    this.date = date;
    return this;
  }

  /**
   * Date of the assignment
   * @return date
  **/
  @ApiModelProperty(value = "Date of the assignment")

  @Valid
  public LocalDate getDate() {
    return date;
  }

  public void setDate(LocalDate date) {
    this.date = date;
  }

  public ShiftAssignment employee(String employee) {
    this.employee = employee;
    return this;
  }

  /**
   * Employee name
   * @return employee
  **/
  @ApiModelProperty(value = "Employee name")

  public String getEmployee() {
    return employee;
  }

  public void setEmployee(String employee) {
    this.employee = employee;
  }

  public ShiftAssignment skill(String skill) {
    this.skill = skill;
    return this;
  }

  /**
   * Skill name
   * @return skill
  **/
  @ApiModelProperty(value = "Skill name")

  public String getSkill() {
    return skill;
  }

  public void setSkill(String skill) {
    this.skill = skill;
  }

  public ShiftAssignment startDateTime(OffsetDateTime startDateTime) {
    this.startDateTime = startDateTime;
    return this;
  }

  /**
   * Date time of the start of the assignment
   * @return startDateTime
  **/
  @ApiModelProperty(value = "Date time of the start of the assignment")

  @Valid
  public OffsetDateTime getStartDateTime() {
    return startDateTime;
  }

  public void setStartDateTime(OffsetDateTime startDateTime) {
    this.startDateTime = startDateTime;
  }

  public ShiftAssignment endDateTime(OffsetDateTime endDateTime) {
    this.endDateTime = endDateTime;
    return this;
  }

  /**
   * Date time of the start of the assignment
   * @return endDateTime
  **/
  @ApiModelProperty(value = "Date time of the start of the assignment")

  @Valid
  public OffsetDateTime getEndDateTime() {
    return endDateTime;
  }

  public void setEndDateTime(OffsetDateTime endDateTime) {
    this.endDateTime = endDateTime;
  }

  public ShiftAssignment locked(Boolean locked) {
    this.locked = locked;
    return this;
  }

  /**
   * Date time of the start of the assignment
   * @return locked
  **/
  @ApiModelProperty(value = "Date time of the start of the assignment")

  public Boolean isLocked() {
    return locked;
  }

  public void setLocked(Boolean locked) {
    this.locked = locked;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ShiftAssignment shiftAssignment = (ShiftAssignment) o;
    return Objects.equals(this.date, shiftAssignment.date) &&
        Objects.equals(this.employee, shiftAssignment.employee) &&
        Objects.equals(this.skill, shiftAssignment.skill) &&
        Objects.equals(this.startDateTime, shiftAssignment.startDateTime) &&
        Objects.equals(this.endDateTime, shiftAssignment.endDateTime) &&
        Objects.equals(this.locked, shiftAssignment.locked);
  }

  @Override
  public int hashCode() {
    return Objects.hash(date, employee, skill, startDateTime, endDateTime, locked);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ShiftAssignment {\n");
    
    sb.append("    date: ").append(toIndentedString(date)).append("\n");
    sb.append("    employee: ").append(toIndentedString(employee)).append("\n");
    sb.append("    skill: ").append(toIndentedString(skill)).append("\n");
    sb.append("    startDateTime: ").append(toIndentedString(startDateTime)).append("\n");
    sb.append("    endDateTime: ").append(toIndentedString(endDateTime)).append("\n");
    sb.append("    locked: ").append(toIndentedString(locked)).append("\n");
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
