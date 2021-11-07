using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HellknightArmigerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("23c225f6-bed6-47ef-80b9-849a2c8ca9c9");

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
            yield return new TextBlock { Id = Guid.Parse("27b3adf1-eede-40c8-9d46-75f4bb4841ec"), Type = TextBlockType.Text, Text = "~ Access: You are from Old Cheliax." };
            yield return new TextBlock { Id = Guid.Parse("2c548fb0-27c2-43bb-b813-e7599bcfc43a"), Type = TextBlockType.Text, Text = "Your Hellknight training teaches you to terrorize others into compliance, but you also study the structure and hierarchy of Hell. You must survive painful tests of your body and mind called reckonings, which steady your mind against all sorts of trauma. You gain resistance to mental damage equal to 1 + your number of class feats from the Hellknight Armiger archetype and other Hellknight archetypes. You become trained in Intimidation and Hell Lore; if you were already trained, you become an expert instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("287790a1-5df4-4ab0-bdde-e2f4e4198ebe"), "Member of a Hellknight order.");
            builder.HaveSpecificArmorCategorySpecificProficiency(Guid.Parse("584a450a-7304-4426-82c4-1419e0dd5631"), Proficiencies.Instances.Trained.ID, ArmorCategories.Instances.Heavy.ID);
            builder.HaveFavoredWeaponSpecificProficiency(Guid.Parse("de5d263f-9949-4ea1-88c4-aaa44eb3fb3b"), Proficiencies.Instances.Trained.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34211731-de88-47ca-9692-d712cf129c9d"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
