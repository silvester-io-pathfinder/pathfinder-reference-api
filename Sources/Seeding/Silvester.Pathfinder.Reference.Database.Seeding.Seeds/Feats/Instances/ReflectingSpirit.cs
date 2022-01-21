using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReflectingSpirit : Template
    {
        public static readonly Guid ID = Guid.Parse("4ce9d3e3-aac4-404a-8754-93c9afe650f9");

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
            yield return new TextBlock { Id = Guid.Parse("c8f368c2-b36d-45ea-aaa2-a31d832e1663"), Type = TextBlockType.Text, Text = "You gain a +2 status bonus to AC against physical ranged attacks. If an enemy's physical ranged attack misses you, you can use your reaction to immediately attempt a ranged (action: Strike) against the attacker using the projectile that missed." };
            yield return new TextBlock { Id = Guid.Parse("cd8f5d91-b0ff-4dee-8c0e-0f5d644bacc9"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ You have weakness 5 to physical ranged attacks." };
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
                Id = Guid.Parse("d68d438a-0b60-45de-824c-a4a4a6f776d1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
