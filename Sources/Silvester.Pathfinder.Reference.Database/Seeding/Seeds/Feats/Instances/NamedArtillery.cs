using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NamedArtillery : Template
    {
        public static readonly Guid ID = Guid.Parse("e1b52e20-c4a9-4a12-8e7a-e5734000a3e3");

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
            yield return new TextBlock { Id = Guid.Parse("97366701-1814-4010-ada2-a8a3326bdf34"), Type = TextBlockType.Text, Text = "It is a tradition among artillerists to name the siege weapon most important to them and closest to their heart—much as a sailor on a ship, the weapon is their livelihood. You’ve gone a step further, and you always make sure that your named artillery has the best possible maintenance and upkeep. You can spend a full day adjusting and working on a single siege weapon to designate it as your named artillery. The siege weapon you designated as your named artillery gains a +2 circumstance bonus to AC, Fortitude saves, and Reflex saves as well as additional Hit Points equal to twice your level." };
            yield return new TextBlock { Id = Guid.Parse("3194613d-dc4c-4abc-833f-ef18d276d98a"), Type = TextBlockType.Text, Text = "During your daily preparations, you must spend at least one hour on maintenance to service your named artillery. If you fail to do so, or if you spend a full day designating a new piece of named artillery, the previous named artillery loses any benefits from this feat. Only one artillerist can designate a particular siege weapon as their named artillery, even if several artillerists are serving on the same siege weapon’s crew (though it’s typically more efficient for a group with several artillerists to divide them up, assigning one to each siege weapon)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7a2471cf-935f-4bc6-9a9c-12b8bb1836b3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("886a40f1-91c9-4c4a-8298-34595ea651bc"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
