package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.model.Solver;
import io.swagger.model.Status;
import java.util.UUID;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * SolutionJob
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class SolutionJob   {
  @JsonProperty("id")
  private UUID id = null;

  @JsonProperty("solver")
  private Solver solver = null;

  @JsonProperty("status")
  private Status status = null;

  public SolutionJob id(UUID id) {
    this.id = id;
    return this;
  }

  /**
   * Get id
   * @return id
  **/
  @ApiModelProperty(value = "")

  @Valid
  public UUID getId() {
    return id;
  }

  public void setId(UUID id) {
    this.id = id;
  }

  public SolutionJob solver(Solver solver) {
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

  public SolutionJob status(Status status) {
    this.status = status;
    return this;
  }

  /**
   * Get status
   * @return status
  **/
  @ApiModelProperty(value = "")

  @Valid
  public Status getStatus() {
    return status;
  }

  public void setStatus(Status status) {
    this.status = status;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SolutionJob solutionJob = (SolutionJob) o;
    return Objects.equals(this.id, solutionJob.id) &&
        Objects.equals(this.solver, solutionJob.solver) &&
        Objects.equals(this.status, solutionJob.status);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, solver, status);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SolutionJob {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    solver: ").append(toIndentedString(solver)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
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
