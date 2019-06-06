package io.swagger.model;

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import io.swagger.model.Demand;
import io.swagger.model.Employee;
import io.swagger.model.ShiftAssignment;
import io.swagger.model.SolveJob;
import io.swagger.model.Solver;
import io.swagger.model.Statute;
import java.util.ArrayList;
import java.util.List;
import org.springframework.validation.annotation.Validated;
import javax.validation.Valid;
import javax.validation.constraints.*;

/**
 * ShiftRequest
 */
@Validated
@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.SpringCodegen", date = "2019-06-06T16:32:15.795+02:00[Europe/Brussels]")
public class ShiftRequest extends SolveJob  {
  @JsonProperty("demand")
  @Valid
  private List<Demand> demand = new ArrayList<Demand>();

  @JsonProperty("employees")
  @Valid
  private List<Employee> employees = new ArrayList<Employee>();

  @JsonProperty("statutes")
  @Valid
  private List<Statute> statutes = new ArrayList<Statute>();

  @JsonProperty("assignments")
  @Valid
  private List<ShiftAssignment> assignments = null;

  public ShiftRequest demand(List<Demand> demand) {
    this.demand = demand;
    return this;
  }

  public ShiftRequest addDemandItem(Demand demandItem) {
    this.demand.add(demandItem);
    return this;
  }

  /**
   * Demand blocks for which a certain number of employees by a certain skill and on a certain location are required.
   * @return demand
  **/
  @ApiModelProperty(required = true, value = "Demand blocks for which a certain number of employees by a certain skill and on a certain location are required.")
  @NotNull
  @Valid
  public List<Demand> getDemand() {
    return demand;
  }

  public void setDemand(List<Demand> demand) {
    this.demand = demand;
  }

  public ShiftRequest employees(List<Employee> employees) {
    this.employees = employees;
    return this;
  }

  public ShiftRequest addEmployeesItem(Employee employeesItem) {
    this.employees.add(employeesItem);
    return this;
  }

  /**
   * Group of employees available to be planned in the planning period defined by the demand.
   * @return employees
  **/
  @ApiModelProperty(required = true, value = "Group of employees available to be planned in the planning period defined by the demand.")
  @NotNull
  @Valid
  public List<Employee> getEmployees() {
    return employees;
  }

  public void setEmployees(List<Employee> employees) {
    this.employees = employees;
  }

  public ShiftRequest statutes(List<Statute> statutes) {
    this.statutes = statutes;
    return this;
  }

  public ShiftRequest addStatutesItem(Statute statutesItem) {
    this.statutes.add(statutesItem);
    return this;
  }

  /**
   * Statute definitions used by employees.
   * @return statutes
  **/
  @ApiModelProperty(required = true, value = "Statute definitions used by employees.")
  @NotNull
  @Valid
  public List<Statute> getStatutes() {
    return statutes;
  }

  public void setStatutes(List<Statute> statutes) {
    this.statutes = statutes;
  }

  public ShiftRequest assignments(List<ShiftAssignment> assignments) {
    this.assignments = assignments;
    return this;
  }

  public ShiftRequest addAssignmentsItem(ShiftAssignment assignmentsItem) {
    if (this.assignments == null) {
      this.assignments = new ArrayList<ShiftAssignment>();
    }
    this.assignments.add(assignmentsItem);
    return this;
  }

  /**
   * Pre made assignments that the solver should take into account
   * @return assignments
  **/
  @ApiModelProperty(value = "Pre made assignments that the solver should take into account")
  @Valid
  public List<ShiftAssignment> getAssignments() {
    return assignments;
  }

  public void setAssignments(List<ShiftAssignment> assignments) {
    this.assignments = assignments;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ShiftRequest shiftRequest = (ShiftRequest) o;
    return Objects.equals(this.demand, shiftRequest.demand) &&
        Objects.equals(this.employees, shiftRequest.employees) &&
        Objects.equals(this.statutes, shiftRequest.statutes) &&
        Objects.equals(this.assignments, shiftRequest.assignments) &&
        super.equals(o);
  }

  @Override
  public int hashCode() {
    return Objects.hash(demand, employees, statutes, assignments, super.hashCode());
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ShiftRequest {\n");
    sb.append("    ").append(toIndentedString(super.toString())).append("\n");
    sb.append("    demand: ").append(toIndentedString(demand)).append("\n");
    sb.append("    employees: ").append(toIndentedString(employees)).append("\n");
    sb.append("    statutes: ").append(toIndentedString(statutes)).append("\n");
    sb.append("    assignments: ").append(toIndentedString(assignments)).append("\n");
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
