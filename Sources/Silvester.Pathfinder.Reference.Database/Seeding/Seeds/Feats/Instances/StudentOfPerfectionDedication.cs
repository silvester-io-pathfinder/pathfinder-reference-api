using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StudentOfPerfectionDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("afcefdb7-d621-4e14-95c7-97fcdf4f4bee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Student of Perfection Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the student of perfection archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1f26ea47-be1c-4272-a6ad-15f7e0731236"), Type = TextBlockType.Text, Text = "~ Access: You are from Jalmeray." };
            yield return new TextBlock { Id = Guid.Parse("9196c6d0-6583-4dd1-ab79-bba080de90a2"), Type = TextBlockType.Text, Text = "You have learned the martial arts techniques of your House of Perfection. You become trained in your choice of Acrobatics or Athletics and Warfare Lore; if you were already trained, you become an expert instead. You gain the (feat: Ki Strike) class feat, which grants you the (spell: ki strike) ki spell and a focus pool of 1 Focus Point that you can recover using the (action: Refocus) activity as a monk does. Your ki spells from Student of Perfection are occult spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("952c9f2b-2536-4f71-97e4-4024cbefc035"), or => 
            {
                or.HaveSpecificClassFeature(Guid.Parse("17477ffa-bdc5-41bc-8435-916da4a3976d"), ClassFeatures.Monks.PowerfulFist.ID);
                or.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("bde557d5-d8db-4fe3-994a-1432c64ae697"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
            });
            builder.Manual(Guid.Parse("897b4adb-c0e6-40fc-a329-8111e8cddf19"), "Member of a House of Perfection.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("712fbec2-c46c-4606-9541-1c535724c8d3"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
