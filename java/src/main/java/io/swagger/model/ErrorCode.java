package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * ErrorCode
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class ErrorCode   {
  @JsonProperty("errorCode")
  private String errorCode = null;

  @JsonProperty("explanation")
  private String explanation = null;

  @JsonProperty("line")
  private Integer line = null;

  @JsonProperty("column")
  private Integer column = null;

  public ErrorCode errorCode(String errorCode) {
    this.errorCode = errorCode;
    return this;
  }

  /**
   * Get errorCode
   * @return errorCode
  **/
  @ApiModelProperty(value = "")

  public String getErrorCode() {
    return errorCode;
  }

  public void setErrorCode(String errorCode) {
    this.errorCode = errorCode;
  }

  public ErrorCode explanation(String explanation) {
    this.explanation = explanation;
    return this;
  }

  /**
   * Get explanation
   * @return explanation
  **/
  @ApiModelProperty(value = "")

  public String getExplanation() {
    return explanation;
  }

  public void setExplanation(String explanation) {
    this.explanation = explanation;
  }

  public ErrorCode line(Integer line) {
    this.line = line;
    return this;
  }

  /**
   * Get line
   * @return line
  **/
  @ApiModelProperty(value = "")

  public Integer getLine() {
    return line;
  }

  public void setLine(Integer line) {
    this.line = line;
  }

  public ErrorCode column(Integer column) {
    this.column = column;
    return this;
  }

  /**
   * Get column
   * @return column
  **/
  @ApiModelProperty(value = "")

  public Integer getColumn() {
    return column;
  }

  public void setColumn(Integer column) {
    this.column = column;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ErrorCode errorCode = (ErrorCode) o;
    return Objects.equals(this.errorCode, errorCode.errorCode) &&
        Objects.equals(this.explanation, errorCode.explanation) &&
        Objects.equals(this.line, errorCode.line) &&
        Objects.equals(this.column, errorCode.column);
  }

  @Override
  public int hashCode() {
    return Objects.hash(errorCode, explanation, line, column);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ErrorCode {\n");
    
    sb.append("    errorCode: ").append(toIndentedString(errorCode)).append("\n");
    sb.append("    explanation: ").append(toIndentedString(explanation)).append("\n");
    sb.append("    line: ").append(toIndentedString(line)).append("\n");
    sb.append("    column: ").append(toIndentedString(column)).append("\n");
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
