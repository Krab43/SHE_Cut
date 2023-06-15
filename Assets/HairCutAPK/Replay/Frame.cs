using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ReplayData
{
    public class Frame
    {
        //transform data
        Vector3 pos, scale;
        Quaternion rot;
        bool _isActive;
        // bool clothEnabled;
        // bool isClothActive;

        //RigidBody velocities
        // Vector3 RBvelocity, RBAngVelocity;

        //audio data
        // AudioData audio;

        //particles data
        float particleTime;

        //Constructor
        public Frame(Vector3 position, Quaternion rotation, Vector3 scale_, bool isActive) //, bool clothEnabled)
        {
            pos = position;
            rot = rotation;
            scale = scale_;
            this._isActive = isActive;
            // this.clothEnabled = clothEnabled;
        }

        //RigidBody set velocity data
        // public void SetRBVelocities(Vector3 v, Vector3 aV)
        // {
        //     RBvelocity = v;
        //     RBAngVelocity = aV;
        // }

        //audio set data
        // public void SetAudioData(AudioData data)
        // {
        //     audio = data;
        // }

        //particle set data
        public void SetParticleData(float time)
        {
            particleTime = time;
        }

        // Cloth set data
        // public void SetClothData(bool enabled)
        // {
        //     clothEnabled = enabled;
        // }

        //Getters
        public Vector3 GetPosition() { return pos; }
        public Vector3 GetScale() { return scale; }
        public Quaternion GetRotation() { return rot; }
        public bool GetState() { return _isActive; }
        // public bool GetClothEnabled() { return clothEnabled; }
        

        //RigidBody getter
        // public Vector3 GetRBVelocity() { return RBvelocity; }
        // public Vector3 GetRBAngularVelocity() { return RBAngVelocity; }

        //Audio getter
        // public AudioData GetAudioData() { return audio; }

        //Particle getter
        public float ParticleTime() { return particleTime; }
    }
}

