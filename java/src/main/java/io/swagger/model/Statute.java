package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.math.BigDecimal;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * Statute
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class Statute   {
  @JsonProperty("name")
  private String name = null;

  @JsonProperty("minShiftLength")
  private Integer minShiftLength = null;

  @JsonProperty("maxShiftLength")
  private Integer maxShiftLength = null;

  @JsonProperty("minRestBetweenShifts")
  private Integer minRestBetweenShifts = null;

  @JsonProperty("maxConsecutiveWorkDays")
  private Integer maxConsecutiveWorkDays = null;

  @JsonProperty("maxHrsPerWeek")
  private Integer maxHrsPerWeek = null;

  @JsonProperty("minHrsPerWeek")
  private Integer minHrsPerWeek = null;

  @JsonProperty("shiftStart")
  private BigDecimal shiftStart = null;

  @JsonProperty("latestShiftStart")
  private BigDecimal latestShiftStart = null;

  @JsonProperty("shiftEnd")
  private BigDecimal shiftEnd = null;

  @JsonProperty("minHoursMonth")
  private Integer minHoursMonth = null;

  @JsonProperty("maxHoursMonth")
  private Integer maxHoursMonth = null;

  @JsonProperty("overTimeThreshold1")
  private BigDecimal overTimeThreshold1 = null;

  @JsonProperty("overTimeRaise1")
  private BigDecimal overTimeRaise1 = null;

  @JsonProperty("overTimeThreshold2")
  private BigDecimal overTimeThreshold2 = null;

  @JsonProperty("overTimeRaise2")
  private BigDecimal overTimeRaise2 = null;

  @JsonProperty("overTimeWeeklyThreshold1")
  private BigDecimal overTimeWeeklyThreshold1 = null;

  @JsonProperty("overTimeWeeklyRaise1")
  private BigDecimal overTimeWeeklyRaise1 = null;

  @JsonProperty("nightlyThreshold1")
  private BigDecimal nightlyThreshold1 = null;

  @JsonProperty("nightlyRaise")
  private BigDecimal nightlyRaise = null;

  public Statute name(String name) {
    this.name = name;
    return this;
  }

  /**
   * Unique name for a definition of a statute.
   * @return name
  **/
  @ApiModelProperty(example = "FULLTIME", required = true, value = "Unique name for a definition of a statute.")
  @NotNull

  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public Statute minShiftLength(Integer minShiftLength) {
    this.minShiftLength = minShiftLength;
    return this;
  }

  /**
   * The minimum number of hours in a shift for an employee
   * @return minShiftLength
  **/
  @ApiModelProperty(value = "The minimum number of hours in a shift for an employee")

  public Integer getMinShiftLength() {
    return minShiftLength;
  }

  public void setMinShiftLength(Integer minShiftLength) {
    this.minShiftLength = minShiftLength;
  }

  public Statute maxShiftLength(Integer maxShiftLength) {
    this.maxShiftLength = maxShiftLength;
    return this;
  }

  /**
   * The maximum number of hours in a shift for an employee
   * @return maxShiftLength
  **/
  @ApiModelProperty(value = "The maximum number of hours in a shift for an employee")

  public Integer getMaxShiftLength() {
    return maxShiftLength;
  }

  public void setMaxShiftLength(Integer maxShiftLength) {
    this.maxShiftLength = maxShiftLength;
  }

  public Statute minRestBetweenShifts(Integer minRestBetweenShifts) {
    this.minRestBetweenShifts = minRestBetweenShifts;
    return this;
  }

  /**
   * The minimum duration (in hours) of a rest period between two shifts for this employee
   * @return minRestBetweenShifts
  **/
  @ApiModelProperty(value = "The minimum duration (in hours) of a rest period between two shifts for this employee")

  public Integer getMinRestBetweenShifts() {
    return minRestBetweenShifts;
  }

  public void setMinRestBetweenShifts(Integer minRestBetweenShifts) {
    this.minRestBetweenShifts = minRestBetweenShifts;
  }

  public Statute maxConsecutiveWorkDays(Integer maxConsecutiveWorkDays) {
    this.maxConsecutiveWorkDays = maxConsecutiveWorkDays;
    return this;
  }

  /**
   * The maximum days consecutive that this employee can be working
   * @return maxConsecutiveWorkDays
  **/
  @ApiModelProperty(value = "The maximum days consecutive that this employee can be working")

  public Integer getMaxConsecutiveWorkDays() {
    return maxConsecutiveWorkDays;
  }

  public void setMaxConsecutiveWorkDays(Integer maxConsecutiveWorkDays) {
    this.maxConsecutiveWorkDays = maxConsecutiveWorkDays;
  }

  public Statute maxHrsPerWeek(Integer maxHrsPerWeek) {
    this.maxHrsPerWeek = maxHrsPerWeek;
    return this;
  }

  /**
   * The maximum number of hours this employee can be working in a week
   * @return maxHrsPerWeek
  **/
  @ApiModelProperty(value = "The maximum number of hours this employee can be working in a week")

  public Integer getMaxHrsPerWeek() {
    return maxHrsPerWeek;
  }

  public void setMaxHrsPerWeek(Integer maxHrsPerWeek) {
    this.maxHrsPerWeek = maxHrsPerWeek;
  }

  public Statute minHrsPerWeek(Integer minHrsPerWeek) {
    this.minHrsPerWeek = minHrsPerWeek;
    return this;
  }

  /**
   * The minimum number of hours this employee should be working in a week
   * @return minHrsPerWeek
  **/
  @ApiModelProperty(value = "The minimum number of hours this employee should be working in a week")

  public Integer getMinHrsPerWeek() {
    return minHrsPerWeek;
  }

  public void setMinHrsPerWeek(Integer minHrsPerWeek) {
    this.minHrsPerWeek = minHrsPerWeek;
  }

  public Statute shiftStart(BigDecimal shiftStart) {
    this.shiftStart = shiftStart;
    return this;
  }

  /**
   * The earliest this employee can start working (expressed as decimal in 24 hour-format)
   * @return shiftStart
  **/
  @ApiModelProperty(value = "The earliest this employee can start working (expressed as decimal in 24 hour-format)")

  @Valid
  public BigDecimal getShiftStart() {
    return shiftStart;
  }

  public void setShiftStart(BigDecimal shiftStart) {
    this.shiftStart = shiftStart;
  }

  public Statute latestShiftStart(BigDecimal latestShiftStart) {
    this.latestShiftStart = latestShiftStart;
    return this;
  }

  /**
   * The latest this employee can start working (expressed as decimal in 24 hour-format)
   * @return latestShiftStart
  **/
  @ApiModelProperty(value = "The latest this employee can start working (expressed as decimal in 24 hour-format)")

  @Valid
  public BigDecimal getLatestShiftStart() {
    return latestShiftStart;
  }

  public void setLatestShiftStart(BigDecimal latestShiftStart) {
    this.latestShiftStart = latestShiftStart;
  }

  public Statute shiftEnd(BigDecimal shiftEnd) {
    this.shiftEnd = shiftEnd;
    return this;
  }

  /**
   * The latest this employee can work on a day (expressed as decimal in 24 hour-format)
   * @return shiftEnd
  **/
  @ApiModelProperty(value = "The latest this employee can work on a day (expressed as decimal in 24 hour-format)")

  @Valid
  public BigDecimal getShiftEnd() {
    return shiftEnd;
  }

  public void setShiftEnd(BigDecimal shiftEnd) {
    this.shiftEnd = shiftEnd;
  }

  public Statute minHoursMonth(Integer minHoursMonth) {
    this.minHoursMonth = minHoursMonth;
    return this;
  }

  /**
   * The minimum hours per month this employee should be working
   * @return minHoursMonth
  **/
  @ApiModelProperty(value = "The minimum hours per month this employee should be working")

  public Integer getMinHoursMonth() {
    return minHoursMonth;
  }

  public void setMinHoursMonth(Integer minHoursMonth) {
    this.minHoursMonth = minHoursMonth;
  }

  public Statute maxHoursMonth(Integer maxHoursMonth) {
    this.maxHoursMonth = maxHoursMonth;
    return this;
  }

  /**
   * The maximum hours per month this employee should be working
   * @return maxHoursMonth
  **/
  @ApiModelProperty(value = "The maximum hours per month this employee should be working")

  public Integer getMaxHoursMonth() {
    return maxHoursMonth;
  }

  public void setMaxHoursMonth(Integer maxHoursMonth) {
    this.maxHoursMonth = maxHoursMonth;
  }

  public Statute overTimeThreshold1(BigDecimal overTimeThreshold1) {
    this.overTimeThreshold1 = overTimeThreshold1;
    return this;
  }

  /**
   * The first time threshold for overtime (expressed as decimal in 24 hour-format)
   * @return overTimeThreshold1
  **/
  @ApiModelProperty(value = "The first time threshold for overtime (expressed as decimal in 24 hour-format)")

  @Valid
  public BigDecimal getOverTimeThreshold1() {
    return overTimeThreshold1;
  }

  public void setOverTimeThreshold1(BigDecimal overTimeThreshold1) {
    this.overTimeThreshold1 = overTimeThreshold1;
  }

  public Statute overTimeRaise1(BigDecimal overTimeRaise1) {
    this.overTimeRaise1 = overTimeRaise1;
    return this;
  }

  /**
   * The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour)
   * @return overTimeRaise1
  **/
  @ApiModelProperty(value = "The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour)")

  @Valid
  public BigDecimal getOverTimeRaise1() {
    return overTimeRaise1;
  }

  public void setOverTimeRaise1(BigDecimal overTimeRaise1) {
    this.overTimeRaise1 = overTimeRaise1;
  }

  public Statute overTimeThreshold2(BigDecimal overTimeThreshold2) {
    this.overTimeThreshold2 = overTimeThreshold2;
    return this;
  }

  /**
   * The second time threshold for overtime (expressed as decimal in 24 hour-format)
   * @return overTimeThreshold2
  **/
  @ApiModelProperty(value = "The second time threshold for overtime (expressed as decimal in 24 hour-format)")

  @Valid
  public BigDecimal getOverTimeThreshold2() {
    return overTimeThreshold2;
  }

  public void setOverTimeThreshold2(BigDecimal overTimeThreshold2) {
    this.overTimeThreshold2 = overTimeThreshold2;
  }

  public Statute overTimeRaise2(BigDecimal overTimeRaise2) {
    this.overTimeRaise2 = overTimeRaise2;
    return this;
  }

  /**
   * The raise after the second time threshold for overtime (e.q. 1.2 means a 20% raise per hour)
   * @return overTimeRaise2
  **/
  @ApiModelProperty(value = "The raise after the second time threshold for overtime (e.q. 1.2 means a 20% raise per hour)")

  @Valid
  public BigDecimal getOverTimeRaise2() {
    return overTimeRaise2;
  }

  public void setOverTimeRaise2(BigDecimal overTimeRaise2) {
    this.overTimeRaise2 = overTimeRaise2;
  }

  public Statute overTimeWeeklyThreshold1(BigDecimal overTimeWeeklyThreshold1) {
    this.overTimeWeeklyThreshold1 = overTimeWeeklyThreshold1;
    return this;
  }

  /**
   * The number of hours per week after which a \"weekly overtime\" raise should be given
   * @return overTimeWeeklyThreshold1
  **/
  @ApiModelProperty(value = "The number of hours per week after which a \"weekly overtime\" raise should be given")

  @Valid
  public BigDecimal getOverTimeWeeklyThreshold1() {
    return overTimeWeeklyThreshold1;
  }

  public void setOverTimeWeeklyThreshold1(BigDecimal overTimeWeeklyThreshold1) {
    this.overTimeWeeklyThreshold1 = overTimeWeeklyThreshold1;
  }

  public Statute overTimeWeeklyRaise1(BigDecimal overTimeWeeklyRaise1) {
    this.overTimeWeeklyRaise1 = overTimeWeeklyRaise1;
    return this;
  }

  /**
   * The weekly overtime raise (e.q. 1.2 means a 20% raise per hour)
   * @return overTimeWeeklyRaise1
  **/
  @ApiModelProperty(value = "The weekly overtime raise (e.q. 1.2 means a 20% raise per hour)")

  @Valid
  public BigDecimal getOverTimeWeeklyRaise1() {
    return overTimeWeeklyRaise1;
  }

  public void setOverTimeWeeklyRaise1(BigDecimal overTimeWeeklyRaise1) {
    this.overTimeWeeklyRaise1 = overTimeWeeklyRaise1;
  }

  public Statute nightlyThreshold1(BigDecimal nightlyThreshold1) {
    this.nightlyThreshold1 = nightlyThreshold1;
    return this;
  }

  /**
   * The time threshold to be considered for a night raise (expressed as decimal in 24 hour-format)
   * @return nightlyThreshold1
  **/
  @ApiModelProperty(value = "The time threshold to be considered for a night raise (expressed as decimal in 24 hour-format)")

  @Valid
  public BigDecimal getNightlyThreshold1() {
    return nightlyThreshold1;
  }

  public void setNightlyThreshold1(BigDecimal nightlyThreshold1) {
    this.nightlyThreshold1 = nightlyThreshold1;
  }

  public Statute nightlyRaise(BigDecimal nightlyRaise) {
    this.nightlyRaise = nightlyRaise;
    return this;
  }

  /**
   * The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour)
   * @return nightlyRaise
  **/
  @ApiModelProperty(value = "The raise after the first time threshold for overtime (e.q. 1.2 means a 20% raise per hour)")

  @Valid
  public BigDecimal getNightlyRaise() {
    return nightlyRaise;
  }

  public void setNightlyRaise(BigDecimal nightlyRaise) {
    this.nightlyRaise = nightlyRaise;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Statute statute = (Statute) o;
    return Objects.equals(this.name, statute.name) &&
        Objects.equals(this.minShiftLength, statute.minShiftLength) &&
        Objects.equals(this.maxShiftLength, statute.maxShiftLength) &&
        Objects.equals(this.minRestBetweenShifts, statute.minRestBetweenShifts) &&
        Objects.equals(this.maxConsecutiveWorkDays, statute.maxConsecutiveWorkDays) &&
        Objects.equals(this.maxHrsPerWeek, statute.maxHrsPerWeek) &&
        Objects.equals(this.minHrsPerWeek, statute.minHrsPerWeek) &&
        Objects.equals(this.shiftStart, statute.shiftStart) &&
        Objects.equals(this.latestShiftStart, statute.latestShiftStart) &&
        Objects.equals(this.shiftEnd, statute.shiftEnd) &&
        Objects.equals(this.minHoursMonth, statute.minHoursMonth) &&
        Objects.equals(this.maxHoursMonth, statute.maxHoursMonth) &&
        Objects.equals(this.overTimeThreshold1, statute.overTimeThreshold1) &&
        Objects.equals(this.overTimeRaise1, statute.overTimeRaise1) &&
        Objects.equals(this.overTimeThreshold2, statute.overTimeThreshold2) &&
        Objects.equals(this.overTimeRaise2, statute.overTimeRaise2) &&
        Objects.equals(this.overTimeWeeklyThreshold1, statute.overTimeWeeklyThreshold1) &&
        Objects.equals(this.overTimeWeeklyRaise1, statute.overTimeWeeklyRaise1) &&
        Objects.equals(this.nightlyThreshold1, statute.nightlyThreshold1) &&
        Objects.equals(this.nightlyRaise, statute.nightlyRaise);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, minShiftLength, maxShiftLength, minRestBetweenShifts, maxConsecutiveWorkDays, maxHrsPerWeek, minHrsPerWeek, shiftStart, latestShiftStart, shiftEnd, minHoursMonth, maxHoursMonth, overTimeThreshold1, overTimeRaise1, overTimeThreshold2, overTimeRaise2, overTimeWeeklyThreshold1, overTimeWeeklyRaise1, nightlyThreshold1, nightlyRaise);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Statute {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    minShiftLength: ").append(toIndentedString(minShiftLength)).append("\n");
    sb.append("    maxShiftLength: ").append(toIndentedString(maxShiftLength)).append("\n");
    sb.append("    minRestBetweenShifts: ").append(toIndentedString(minRestBetweenShifts)).append("\n");
    sb.append("    maxConsecutiveWorkDays: ").append(toIndentedString(maxConsecutiveWorkDays)).append("\n");
    sb.append("    maxHrsPerWeek: ").append(toIndentedString(maxHrsPerWeek)).append("\n");
    sb.append("    minHrsPerWeek: ").append(toIndentedString(minHrsPerWeek)).append("\n");
    sb.append("    shiftStart: ").append(toIndentedString(shiftStart)).append("\n");
    sb.append("    latestShiftStart: ").append(toIndentedString(latestShiftStart)).append("\n");
    sb.append("    shiftEnd: ").append(toIndentedString(shiftEnd)).append("\n");
    sb.append("    minHoursMonth: ").append(toIndentedString(minHoursMonth)).append("\n");
    sb.append("    maxHoursMonth: ").append(toIndentedString(maxHoursMonth)).append("\n");
    sb.append("    overTimeThreshold1: ").append(toIndentedString(overTimeThreshold1)).append("\n");
    sb.append("    overTimeRaise1: ").append(toIndentedString(overTimeRaise1)).append("\n");
    sb.append("    overTimeThreshold2: ").append(toIndentedString(overTimeThreshold2)).append("\n");
    sb.append("    overTimeRaise2: ").append(toIndentedString(overTimeRaise2)).append("\n");
    sb.append("    overTimeWeeklyThreshold1: ").append(toIndentedString(overTimeWeeklyThreshold1)).append("\n");
    sb.append("    overTimeWeeklyRaise1: ").append(toIndentedString(overTimeWeeklyRaise1)).append("\n");
    sb.append("    nightlyThreshold1: ").append(toIndentedString(nightlyThreshold1)).append("\n");
    sb.append("    nightlyRaise: ").append(toIndentedString(nightlyRaise)).append("\n");
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
