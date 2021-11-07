using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExplosiveEntry : Template
    {
        public static readonly Guid ID = Guid.Parse("f4f97c44-8fa5-49cf-810e-82daa531f013");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Explosive Entry",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d52b661-7347-4d4c-be81-daa4134c5604"), Type = TextBlockType.Text, Text = "You know exactly how to make a memorable entrance... by detonating a bomb to produce a devastating explosion, of course! You (feat: Set Explosives) on a door, window, container, or heavy gate. When the explosives detonate, you can attempt an Engineering Lore check to (action: Force Open) the target. If a bomb would add an item bonus to attack rolls, add that item bonus to your Engineering Lore check. Since you’re blasting your way in, you can’t avoid breaking the object or structure. If you roll a critical success, you get a success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4bdbd015-f12f-463a-abb3-9fa2aba01b3d"), Feats.Instances.DemolitionistDedication.ID);
            builder.HaveSpecificLoreSpecificProficiency(Guid.Parse("c5fa0b08-29fa-4f54-bf2e-a4892e4ffc6e"), Proficiencies.Instances.Master.ID, Lores.Instances.Engineering.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("978bfd26-f402-47c5-bce9-2a18a7159eba"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
