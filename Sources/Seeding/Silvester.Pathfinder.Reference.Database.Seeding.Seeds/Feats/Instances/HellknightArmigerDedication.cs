using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HellknightArmigerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("9329b2ae-d05f-4c2c-8205-18c28cbcca45");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hellknight Armiger Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat except dedication feats for higher positions within the Hellknights until you have gained two other feats from the Hellknight armiger archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("05ccc0f1-156c-4ac2-a580-722ab5f71058"), Type = TextBlockType.Text, Text = $"~ Access: You are from Old Cheliax." };
            yield return new TextBlock { Id = Guid.Parse("f7eaedc9-a550-4a16-acb0-a12cacdefd09"), Type = TextBlockType.Text, Text = $"Your Hellknight training teaches you to terrorize others into compliance, but you also study the structure and hierarchy of Hell. You must survive painful tests of your body and mind called reckonings, which steady your mind against all sorts of trauma. You gain resistance to mental damage equal to 1 + your number of class feats from the Hellknight Armiger archetype and other Hellknight archetypes. You become trained in Intimidation and Hell Lore; if you were already trained, you become an expert instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("eca6e00f-b773-43cd-9a8c-3d1de3de5fa2"), "Member of a Hellknight order.");
            builder.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("a0dfaf45-e5e3-408c-b170-0c99771b6796"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.HeavyArmor.ID);
            builder.HaveFavoredWeaponSpecificProficiency(Guid.Parse("eccc8bb2-bef7-4c5e-838d-945151e2b81d"), Proficiencies.Instances.Trained.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b521f0d-7337-4ce4-a060-79e41b27ec55"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
