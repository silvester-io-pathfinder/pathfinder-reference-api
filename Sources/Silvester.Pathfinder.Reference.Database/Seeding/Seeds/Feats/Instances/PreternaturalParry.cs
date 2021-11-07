using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PreternaturalParry : Template
    {
        public static readonly Guid ID = Guid.Parse("5b5bd45f-ae32-447c-a64a-c32731a5398a");

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
            yield return new TextBlock { Id = Guid.Parse("38c69305-4db7-4f9c-bdf3-e82e0f43c3bf"), Type = TextBlockType.Text, Text = "You snap your weapon or limb into place to ward off harm at the last second. You gain a +2 circumstance bonus to AC and saving throws against the triggering effect until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3b1d2813-ccc5-48c0-b14b-1459dc1eb195"), Feats.Instances.SpellParry.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b203476-7eab-43ee-9f2f-314e0af08b00"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
