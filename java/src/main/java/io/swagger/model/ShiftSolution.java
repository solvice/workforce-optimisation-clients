package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.model.BlockAssignment;
import io.swagger.model.SolutionJob;
import io.swagger.model.Solver;
import io.swagger.model.Status;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.UUID;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * ShiftSolution
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class ShiftSolution extends SolutionJob  {
  @JsonProperty("solution")
  @Valid
  private Map<String, List<BlockAssignment>> solution = null;

  public ShiftSolution solution(Map<String, List<BlockAssignment>> solution) {
    this.solution = solution;
    return this;
  }

  public ShiftSolution putSolutionItem(String key, List<BlockAssignment> solutionItem) {
    if (this.solution == null) {
      this.solution = new HashMap<String, List<BlockAssignment>>();
    }
    this.solution.put(key, solutionItem);
    return this;
  }

  /**
   * Get solution
   * @return solution
  **/
  @ApiModelProperty(value = "")
  @Valid
  public Map<String, List<BlockAssignment>> getSolution() {
    return solution;
  }

  public void setSolution(Map<String, List<BlockAssignment>> solution) {
    this.solution = solution;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ShiftSolution shiftSolution = (ShiftSolution) o;
    return Objects.equals(this.solution, shiftSolution.solution) &&
        super.equals(o);
  }

  @Override
  public int hashCode() {
    return Objects.hash(solution, super.hashCode());
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ShiftSolution {\n");
    sb.append("    ").append(toIndentedString(super.toString())).append("\n");
    sb.append("    solution: ").append(toIndentedString(solution)).append("\n");
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
