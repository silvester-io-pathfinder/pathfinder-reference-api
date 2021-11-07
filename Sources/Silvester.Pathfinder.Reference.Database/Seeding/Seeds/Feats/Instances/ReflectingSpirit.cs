using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReflectingSpirit : Template
    {
        public static readonly Guid ID = Guid.Parse("cf36d4c5-ba65-43cb-b91f-a289c6703c36");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reflecting Spirit",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04bbe97a-5ead-42ff-b8f6-597b65b0ccb0"), Type = TextBlockType.Text, Text = "You gain a +2 status bonus to AC against physical ranged attacks. If an enemy’s physical ranged attack misses you, you can use your reaction to immediately attempt a ranged (action: Strike) against the attacker using the projectile that missed." };
            yield return new TextBlock { Id = Guid.Parse("27fd114d-ce61-4b3a-b028-13eda8f23390"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ You have weakness 5 to physical ranged attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("178fd498-3850-4b82-a63a-bd05eb02277b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
