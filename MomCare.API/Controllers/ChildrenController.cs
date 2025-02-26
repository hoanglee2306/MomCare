using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MomCare.Application.Interfaces;
using MomCare.Application.Requests;

namespace MomCare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildrenController : ControllerBase
    {
        public IChildrenService _childrenService;
        public ChildrenController(IChildrenService childrenService)
        {
            _childrenService = childrenService;
        }
        [HttpPost("AddNewChildren")]
        public async Task<IActionResult> AddNewChildren(ChildrenRequest childrentRequest)
        {
            var result = await _childrenService.AddNewChildren(childrentRequest);
            return result.IsSuccess ? Ok(result) : BadRequest(result);
        }
        [HttpGet("GetAllChildren")]
        public async Task<IActionResult> GetAllChildren()
        {
            var response = await _childrenService.GetAllChildren();
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpDelete("DeleteChildrenDetail{id}")]
        public async Task<IActionResult> DeleteChildrenDetail(Guid id)
        {
            var response = await _childrenService.DeleteChildrenData(id);
            return response.IsSuccess ? Ok(response) : BadRequest(response);
        }
        [HttpPut("UpdateChildrenData")]
        public async Task<IActionResult> UpdateChildrenData(ChildrenRequest childrentRequest)
        {
            var resposne = await _childrenService.UpdateChildrenData(childrentRequest);
            return resposne.IsSuccess ? Ok(resposne) : BadRequest(resposne);
        }
    }
}
