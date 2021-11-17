using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StudentOfPerfectionDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("26428566-2206-42c4-a8a9-44cf07c58fb6");

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
            yield return new TextBlock { Id = Guid.Parse("236160d9-3a7a-4fe9-a360-d0094e2d7813"), Type = TextBlockType.Text, Text = "~ Access: You are from Jalmeray." };
            yield return new TextBlock { Id = Guid.Parse("ee865d75-331c-46f8-94ba-341aa362358b"), Type = TextBlockType.Text, Text = "You have learned the martial arts techniques of your House of Perfection. You become trained in your choice of Acrobatics or Athletics and Warfare Lore; if you were already trained, you become an expert instead. You gain the (feat: Ki Strike) class feat, which grants you the (spell: ki strike) ki spell and a focus pool of 1 Focus Point that you can recover using the (action: Refocus) activity as a monk does. Your ki spells from Student of Perfection are occult spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b3e958bc-8acd-4216-bbd2-553fb5d4a6b8"), or => 
            {
                or.HaveSpecificClassFeature(Guid.Parse("6a3d05f6-b7a2-4f3c-8a7a-63564fd64169"), ClassFeatures.Monks.PowerfulFist.ID);
                or.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("39ac0c08-8583-4384-8ef2-af16fe3a90bd"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
            });
            builder.Manual(Guid.Parse("e06be125-59cc-4d80-827b-1b9c9a2bfa4e"), "Member of a House of Perfection.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4f903a9-01a2-4430-b73c-232b62e11165"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}