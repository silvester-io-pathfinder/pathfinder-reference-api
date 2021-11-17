using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrystalKeeperDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d03e4510-87d7-4024-923e-3091e2b18d2c");

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
            yield return new TextBlock { Id = Guid.Parse("a7b26667-e16d-4f72-9ce8-24d27cc9ef71"), Type = TextBlockType.Text, Text = "You can use Arcana, Occultism, Religion, or Society to (action: Decipher Writing) by meditating before a crystal, regardless of the type of writing. When you (action: Decipher Writing) and roll a critical failure, you get a failure instead, and when you (action: Decipher Writing) and roll a success, you get a critical success instead." };
            yield return new TextBlock { Id = Guid.Parse("17c88bb7-1770-484d-a9a9-3d7fa53ff388"), Type = TextBlockType.Text, Text = "Additionally, you gain resistance 10 to damage from hazards associated with crystals." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("5cfa1728-697f-4654-8425-7315394a4615"), or => 
            {
                or.HaveSpecificLoreSpecificProficiency(Guid.Parse("7eb05e92-13ed-4427-aec8-91b5f1e9cbf5"), Proficiencies.Instances.Trained.ID, Lores.Instances.Elven.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("d93d6e20-3da3-4495-93fd-0626288891b1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
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
                Id = Guid.Parse("5d830204-1fca-49ca-8ac6-02787287eb08"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
