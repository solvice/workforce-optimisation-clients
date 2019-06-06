package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.model.ErrorCode;
import java.util.ArrayList;
import java.util.List;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * InlineResponse400
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class InlineResponse400   {
  @JsonProperty("errors")
  @Valid
  private List<ErrorCode> errors = null;

  public InlineResponse400 errors(List<ErrorCode> errors) {
    this.errors = errors;
    return this;
  }

  public InlineResponse400 addErrorsItem(ErrorCode errorsItem) {
    if (this.errors == null) {
      this.errors = new ArrayList<ErrorCode>();
    }
    this.errors.add(errorsItem);
    return this;
  }

  /**
   * Get errors
   * @return errors
  **/
  @ApiModelProperty(value = "")
  @Valid
  public List<ErrorCode> getErrors() {
    return errors;
  }

  public void setErrors(List<ErrorCode> errors) {
    this.errors = errors;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InlineResponse400 inlineResponse400 = (InlineResponse400) o;
    return Objects.equals(this.errors, inlineResponse400.errors);
  }

  @Override
  public int hashCode() {
    return Objects.hash(errors);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InlineResponse400 {\n");
    
    sb.append("    errors: ").append(toIndentedString(errors)).append("\n");
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
