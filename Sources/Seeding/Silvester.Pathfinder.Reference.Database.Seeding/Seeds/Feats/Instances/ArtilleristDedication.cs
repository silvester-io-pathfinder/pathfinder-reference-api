using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArtilleristDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("d19efe4a-6e81-40f9-84b2-ac96befe056e");

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
            yield return new TextBlock { Id = Guid.Parse("d17a9679-4cfe-4c5b-b32e-ef971239f273"), Type = TextBlockType.Text, Text = "Artillery is a team sport, where every member of the crew has to rely on the other members. At best, a mistake might just waste time. At worst, a misaligned fuse or a badly set pin could cause the whole thing to explode. You’ve taken these lessons to heart, and so your presence on an artillery team assists the entire team at every aspect of the siege weapon’s deployment and usage. If you’re serving on a siege weapon crew, you and all other members gain a +2 circumstance bonus to any checks to Load, Aim, move, or Repair the weapon. When you Aim a siege weapon, you can move the weapon’s aim twice as far as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("71a34b18-a2cd-419f-887d-3565721b1a80"), Proficiencies.Instances.Trained.ID, WeaponCategories.Instances.Martial.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e5723b6-66b0-461b-896c-b1755de6f167"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
