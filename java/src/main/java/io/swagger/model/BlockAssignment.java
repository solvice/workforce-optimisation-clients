package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import org.threeten.bp.LocalDate;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * BlockAssignment
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class BlockAssignment   {
  @JsonProperty("date")
  private LocalDate date = null;

  @JsonProperty("index")
  private Integer index = null;

  public BlockAssignment date(LocalDate date) {
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

  public BlockAssignment index(Integer index) {
    this.index = index;
    return this;
  }

  /**
   * Index number of the block
   * @return index
  **/
  @ApiModelProperty(value = "Index number of the block")

  public Integer getIndex() {
    return index;
  }

  public void setIndex(Integer index) {
    this.index = index;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BlockAssignment blockAssignment = (BlockAssignment) o;
    return Objects.equals(this.date, blockAssignment.date) &&
        Objects.equals(this.index, blockAssignment.index);
  }

  @Override
  public int hashCode() {
    return Objects.hash(date, index);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BlockAssignment {\n");
    
    sb.append("    date: ").append(toIndentedString(date)).append("\n");
    sb.append("    index: ").append(toIndentedString(index)).append("\n");
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
