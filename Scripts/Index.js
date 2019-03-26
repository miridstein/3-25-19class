$(() => {
    $("#add-row").on('click', function () {
        num=num+1;
        $("#rows-div").append(`                <div class="row">
                    <div class="col-md-4">
                        <input type="text" placeholder="First Name" name="people[${num}].firstname" class="form-control" />
                    </div>
                    <div class="col-md-4">
                        <input type="text" placeholder="Last Name" name="people[${num}].lastname" class="form-control" />
                    </div>
                    <div class="col-md-4">
                        <input type="text" placeholder="Age" name="people[${num}].age" class="form-control" />
                    </div>
                </div>`)
    })
})
var num = 0;