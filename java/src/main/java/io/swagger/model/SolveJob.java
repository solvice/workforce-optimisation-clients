package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.model.Solver;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * SolveJob
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class SolveJob   {
  @JsonProperty("solver")
  private Solver solver = null;

  @JsonProperty("hook")
  private String hook = null;

  public SolveJob solver(Solver solver) {
    this.solver = solver;
    return this;
  }

  /**
   * Get solver
   * @return solver
  **/
  @ApiModelProperty(value = "")

  @Valid
  public Solver getSolver() {
    return solver;
  }

  public void setSolver(Solver solver) {
    this.solver = solver;
  }

  public SolveJob hook(String hook) {
    this.hook = hook;
    return this;
  }

  /**
   * Webhook returns solution status after solving in the form of a POST request to the uri given.
   * @return hook
  **/
  @ApiModelProperty(value = "Webhook returns solution status after solving in the form of a POST request to the uri given.")

  public String getHook() {
    return hook;
  }

  public void setHook(String hook) {
    this.hook = hook;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SolveJob solveJob = (SolveJob) o;
    return Objects.equals(this.solver, solveJob.solver) &&
        Objects.equals(this.hook, solveJob.hook);
  }

  @Override
  public int hashCode() {
    return Objects.hash(solver, hook);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SolveJob {\n");
    
    sb.append("    solver: ").append(toIndentedString(solver)).append("\n");
    sb.append("    hook: ").append(toIndentedString(hook)).append("\n");
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
