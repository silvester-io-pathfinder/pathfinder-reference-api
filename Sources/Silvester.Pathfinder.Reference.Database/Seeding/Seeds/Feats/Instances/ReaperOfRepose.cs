using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReaperOfRepose : Template
    {
        public static readonly Guid ID = Guid.Parse("0975a0a2-613a-4081-83d5-c0d73fb58301");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reaper of Repose",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8663db52-b11e-4168-a0a0-6d28b433a833"), Type = TextBlockType.Text, Text = "Your skill and fervor allow you to pierce undead defenses and exploit their weaknesses. When you make an attack using a weapon with which you have master proficiency and hit an undead creature, you ignore 5 points of the creature’s resistances, and the undead’s weaknesses are 2 higher against your attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1142d7b8-7cbb-46d7-9da0-a2b995f53e59"), Feats.Instances.KnightReclaimantDedication.ID);
            builder.AddOr(Guid.Parse("a2288f0f-90f3-46d5-aadf-c9971c0f6725"), or => 
            {
                or.HaveAnyWeaponCategorySpecificProficiency(Guid.Parse("41d0a8b7-90ea-4002-92bc-94e661ce72a8"), Proficiencies.Instances.Master.ID);
                or.HaveAnyWeaponGroupSpecificProficiency(Guid.Parse("353258d1-1bf1-4410-a8b4-a5cae46097cc"), Proficiencies.Instances.Master.ID);
                or.HaveAnyMeleeWeaponSpecificProficiency(Guid.Parse("1a3dad4b-761e-401b-a093-787caf47fe98"), Proficiencies.Instances.Master.ID);
                or.HaveAnyRangedWeaponSpecificProficiency(Guid.Parse("8d090b62-26a1-4943-95ab-73b41d2db864"), Proficiencies.Instances.Master.ID);
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
                Id = Guid.Parse("a72e18ec-b22d-4b82-867c-7630d0bda787"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
