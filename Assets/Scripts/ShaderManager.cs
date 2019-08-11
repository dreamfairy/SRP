using UnityEngine;

public class ShaderManager {

	public static readonly int OPAQUE_DEPTH_TEXTURE = Shader.PropertyToID("_OpaqueDepthTexture");
	public static readonly int OPAQUE_NORMAL_TEXTURE = Shader.PropertyToID("_OpaqueNormalTexture");
	public static readonly int TRANSPARENT_MIN_DEPTH_TEXTURE = Shader.PropertyToID("_TransparentMinDepthTexture");
	public static readonly int TRANSPARENT_MAX_DEPTH_TEXTURE = Shader.PropertyToID("_TransparentMaxDepthTexture");
	public static readonly int DEPTH_BOUND_TEXTURE = Shader.PropertyToID("_DepthBoundTexture");
	public static readonly int DEPTH_FRUSTUM_TEXTURE = Shader.PropertyToID("_DepthFrustumTexture");
	public static readonly int CULLED_POINT_LIGHT_TEXTURE = Shader.PropertyToID("_CulledPointLightTexture");
	public static readonly int CULLED_SPOT_LIGHT_TEXTURE = Shader.PropertyToID("_CulledSpotLightTexture");
	public static readonly int TILE_NUMBER = Shader.PropertyToID("_TileNumber");
	public static readonly int CAMERA_FORWARD = Shader.PropertyToID("_CameraForward");
	public static readonly int CAMERA_POSITION = Shader.PropertyToID("_CameraPosition");
	public static readonly int Z_BUFFER_PARAMS = Shader.PropertyToID("_ZBufferParams");
	public static readonly int INVERSE_VP = Shader.PropertyToID("_InverseVP");
	public static readonly int POINT_LIGHT_COUNT = Shader.PropertyToID("_PointLightCount");
	public static readonly int SPOT_LIGHT_COUNT = Shader.PropertyToID("_SpotLightCount");
	public static readonly int POINT_LIGHT_BUFFER = Shader.PropertyToID("_PointLightBuffer");
	public static readonly int SPOT_LIGHT_BUFFER = Shader.PropertyToID("_SpotLightBuffer");
}