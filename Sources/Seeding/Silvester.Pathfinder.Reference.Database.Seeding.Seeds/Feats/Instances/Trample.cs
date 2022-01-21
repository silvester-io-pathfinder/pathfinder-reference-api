using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Trample : Template
    {
        public static readonly Guid ID = Guid.Parse("fd4fb42b-1339-4c0e-9aaa-0471c1bbafc3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trample",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c20b60d6-3705-4806-bf89-46479ed7ebbb"), Type = TextBlockType.Text, Text = "Your eidolon (action: Strides | Stride) up to double its Speed and can move through the spaces of creatures at least one size smaller, Trampling each creature whose space it enters. It can attempt to Trample the same creature only once in a single Trample. It deals bludgeoning damage equal to the damage of its secondary attack against these creatures, which can attempt a basic Reflex save against your spell DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1089b8d6-2cc2-4b7f-b6cf-0115500ef461"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}