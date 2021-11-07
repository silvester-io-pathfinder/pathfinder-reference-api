using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Trample : Template
    {
        public static readonly Guid ID = Guid.Parse("be66f575-02d5-4616-9c0d-0de94b3ae9ea");

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
            yield return new TextBlock { Id = Guid.Parse("31dc81e7-4c2d-4e63-b3dc-cf084af303aa"), Type = TextBlockType.Text, Text = "Your eidolon (action: Strides | Stride) up to double its Speed and can move through the spaces of creatures at least one size smaller, Trampling each creature whose space it enters. It can attempt to Trample the same creature only once in a single Trample. It deals bludgeoning damage equal to the damage of its secondary attack against these creatures, which can attempt a basic Reflex save against your spell DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("552785a5-455f-4da5-a342-5d4f61c2843b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
