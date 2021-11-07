using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrystalKeeperDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("cad27968-c4f9-49e3-a6f5-88d8dc913444");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crystal Keeper Dedication",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the crystal keeper archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("403aed7c-73c7-4bf6-a75f-d5f02025aaf3"), Type = TextBlockType.Text, Text = "You can use Arcana, Occultism, Religion, or Society to (action: Decipher Writing) by meditating before a crystal, regardless of the type of writing. When you (action: Decipher Writing) and roll a critical failure, you get a failure instead, and when you (action: Decipher Writing) and roll a success, you get a critical success instead." };
            yield return new TextBlock { Id = Guid.Parse("d4bb9896-cdba-44e1-9b1e-26cc3b5e9499"), Type = TextBlockType.Text, Text = "Additionally, you gain resistance 10 to damage from hazards associated with crystals." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b8e1968e-2e41-47b8-ada9-b53d15e6390e"), or => 
            {
                or.HaveSpecificLoreSpecificProficiency(Guid.Parse("d7e4060c-5f4e-4fe5-861e-1a956b923754"), Proficiencies.Instances.Trained.ID, Lores.Instances.Elven.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("4ef52f90-7a87-4ea6-878a-1d5bb3635bde"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f593ed6-b39e-4469-a556-b25c744742f7"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
