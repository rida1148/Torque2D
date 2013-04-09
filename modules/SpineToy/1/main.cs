/*******************************************************************************
 * Copyright (c) 2013, Esoteric Software
 * All rights reserved.
 * 
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 * 
 * 1. Redistributions of source code must retain the above copyright notice, this
 *    list of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright notice,
 *    this list of conditions and the following disclaimer in the documentation
 *    and/or other materials provided with the distribution.
 * 
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
 * ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
 * ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 ******************************************************************************/

// This is called when the module is loaded
function SpineToy::create(%this)
{
    // Set the sandbox drag mode availability.
    Sandbox.allowManipulation( pan );

    // Set the manipulation mode.
    Sandbox.useManipulation( pan );

    // Reset the toy.
    SpineToy.reset();
}

// This is called when the module is destroyed
function SpineToy::destroy(%this)
{
}

// This can be used to reset the state of a module,
// without reloading it entirely
function SpineToy::reset(%this)
{
    // Clear the scene.
    SandboxScene.clear();

    //%spineSkeletonObject = new SkeletonObject();
    //%spineSkeletonObject.Skeleton = "SpineToy:TestSkeleton";
    //SandboxScene.add(%spineSkeletonObject);
    
    // BEGIN: This code is just for testing name based frames
    %this.createStaticSprite();
    //%this.createAnimatedSprite();
    //%this.createParticlePlayer();
}

function SpineToy::createStaticSprite(%this)
{
    %this.testSprite = new Sprite();
    %this.testSprite.Size = "10 10";
    %this.testSprite.Position = "0 0";
    %this.testSprite.Image = "SpineToy:Test";
    %this.testSprite.NameFrame = "Trail_Leaf";
    SandboxScene.add(%this.testSprite);
}

function SpineToy::createAnimatedSprite(%this)
{
    %this.testSprite = new Sprite();
    %this.testSprite.Size = "10 10";
    %this.testSprite.Position = "0 0";
    %this.testSprite.Animation = "SpineToy:TestAnimation";
    
    SandboxScene.add(%this.testSprite);
}

function SpineToy::createParticlePlayer(%this)
{
    // Create planetoid bubble.
    %player = new ParticlePlayer();
    %player.BodyType = static;
    %player.Position = %position;
    %player.Particle = "SpineToy:TestParticleAsset";
    %player.SceneLayer = 0;
    SandboxScene.add( %player );
}
// END: This code is just for testing name based frames    