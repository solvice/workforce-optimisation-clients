package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.model.Status;
import java.util.UUID;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * StatusJob
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class StatusJob   {
  @JsonProperty("id")
  private UUID id = null;

  @JsonProperty("solver")
  private String solver = null;

  @JsonProperty("status")
  private Status status = null;

  public StatusJob id(UUID id) {
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

  public StatusJob solver(String solver) {
    this.solver = solver;
    return this;
  }

  /**
   * Solver type
   * @return solver
  **/
  @ApiModelProperty(value = "Solver type")

  public String getSolver() {
    return solver;
  }

  public void setSolver(String solver) {
    this.solver = solver;
  }

  public StatusJob status(Status status) {
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
    StatusJob statusJob = (StatusJob) o;
    return Objects.equals(this.id, statusJob.id) &&
        Objects.equals(this.solver, statusJob.solver) &&
        Objects.equals(this.status, statusJob.status);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, solver, status);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StatusJob {\n");
    
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
