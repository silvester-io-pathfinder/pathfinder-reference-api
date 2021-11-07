using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NamedArtillery : Template
    {
        public static readonly Guid ID = Guid.Parse("936bf406-5aed-4759-9f56-5b0120061a25");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Named Artillery",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7290484-631e-43d9-9c3a-e0193ca6e804"), Type = TextBlockType.Text, Text = "It is a tradition among artillerists to name the siege weapon most important to them and closest to their heart—much as a sailor on a ship, the weapon is their livelihood. You’ve gone a step further, and you always make sure that your named artillery has the best possible maintenance and upkeep. You can spend a full day adjusting and working on a single siege weapon to designate it as your named artillery. The siege weapon you designated as your named artillery gains a +2 circumstance bonus to AC, Fortitude saves, and Reflex saves as well as additional Hit Points equal to twice your level." };
            yield return new TextBlock { Id = Guid.Parse("f70c88e1-0d41-4eb3-975e-dc2e5489a362"), Type = TextBlockType.Text, Text = "During your daily preparations, you must spend at least one hour on maintenance to service your named artillery. If you fail to do so, or if you spend a full day designating a new piece of named artillery, the previous named artillery loses any benefits from this feat. Only one artillerist can designate a particular siege weapon as their named artillery, even if several artillerists are serving on the same siege weapon’s crew (though it’s typically more efficient for a group with several artillerists to divide them up, assigning one to each siege weapon)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("04226134-84d7-4093-a5d1-a092dfc2c7c4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5e5d363-58e1-4356-8456-9dd7a4b3388f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
