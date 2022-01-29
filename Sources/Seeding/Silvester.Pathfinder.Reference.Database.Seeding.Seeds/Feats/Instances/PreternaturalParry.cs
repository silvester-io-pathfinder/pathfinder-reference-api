using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PreternaturalParry : Template
    {
        public static readonly Guid ID = Guid.Parse("c769333a-3634-418e-b681-22c48f8a7c27");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Preternatural Parry",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You're targeted by a Strike or a spell attack roll, or you're about to roll a saving throw against a spell effect.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c9dfec2c-bba0-49bb-9c9d-60dcb028af4a"), Type = TextBlockType.Text, Text = $"You snap your weapon or limb into place to ward off harm at the last second. You gain a +2 circumstance bonus to AC and saving throws against the triggering effect until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1ac1cebe-e2c9-425c-8d52-060657d99ad7"), Feats.Instances.SpellParry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a200f2f4-a93f-4435-a05d-4c3702ff6274"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
