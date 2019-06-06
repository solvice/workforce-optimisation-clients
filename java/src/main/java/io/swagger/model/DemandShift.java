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
 * DemandShift
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class DemandShift   {
  @JsonProperty("index")
  private BigDecimal index = null;

  @JsonProperty("date")
  private LocalDate date = null;

  public DemandShift index(BigDecimal index) {
    this.index = index;
    return this;
  }

  /**
   * Index time of shift block in day. (usually 0 - 23 for 1h blocks per day)
   * @return index
  **/
  @ApiModelProperty(value = "Index time of shift block in day. (usually 0 - 23 for 1h blocks per day)")

  @Valid
  public BigDecimal getIndex() {
    return index;
  }

  public void setIndex(BigDecimal index) {
    this.index = index;
  }

  public DemandShift date(LocalDate date) {
    this.date = date;
    return this;
  }

  /**
   * Shift blok date.
   * @return date
  **/
  @ApiModelProperty(value = "Shift blok date.")

  @Valid
  public LocalDate getDate() {
    return date;
  }

  public void setDate(LocalDate date) {
    this.date = date;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DemandShift demandShift = (DemandShift) o;
    return Objects.equals(this.index, demandShift.index) &&
        Objects.equals(this.date, demandShift.date);
  }

  @Override
  public int hashCode() {
    return Objects.hash(index, date);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DemandShift {\n");
    
    sb.append("    index: ").append(toIndentedString(index)).append("\n");
    sb.append("    date: ").append(toIndentedString(date)).append("\n");
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
