using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RipplingSpin : Template
    {
        public static readonly Guid ID = Guid.Parse("c5549654-9f83-4f40-8a06-df46b35c16d8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rippling Spin",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are hit by a physical melee attack by an attacker you can see that's in reach.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92b33422-327e-4eda-876e-6c9a569bf4ab"), Type = TextBlockType.Text, Text = "After the triggering attack is done, (action: Step). You must end this (action: Step) within the attacker’s reach. Then, you can attempt an Athletics check to (action: Disarm) or (action: Trip) the attacker." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1a4583fa-6217-438b-8b4e-f4ce60a4fef4"), Feats.Instances.ReflectiveRippleStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be079ee2-3e0a-4171-b8bb-f6c60421b67b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
