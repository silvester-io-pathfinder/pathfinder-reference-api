using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArtilleristDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("024e6a24-ecaf-4510-9f7d-c784e0331f95");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Artillerist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained at least two other feats from the artillerist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e735b221-9fa9-45b6-9346-4cfa1a2fc2a6"), Type = TextBlockType.Text, Text = "Artillery is a team sport, where every member of the crew has to rely on the other members. At best, a mistake might just waste time. At worst, a misaligned fuse or a badly set pin could cause the whole thing to explode. You’ve taken these lessons to heart, and so your presence on an artillery team assists the entire team at every aspect of the siege weapon’s deployment and usage. If you’re serving on a siege weapon crew, you and all other members gain a +2 circumstance bonus to any checks to Load, Aim, move, or Repair the weapon. When you Aim a siege weapon, you can move the weapon’s aim twice as far as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("b907c7c9-857d-48f2-8b15-d4a2eb0617af"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5401fe6-3c4f-4daa-a4ce-e408bb5197d1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
