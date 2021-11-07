using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StaffAcrobatDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("36e58c00-61b7-4188-9553-dd3860586c50");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Staff Acrobat Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the staff acrobat archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3453a0ec-9fc0-4f6a-9e83-f555343596ae"), Type = TextBlockType.Text, Text = "When you (action: High Jump), (action: Leap), or (action: Long Jump) while wielding your staff, you gain a +2 circumstance bonus to any Athletics check required and add 5 feet to the distance you can (action: Leap) vertically and horizontally." };
            yield return new TextBlock { Id = Guid.Parse("61fb5f36-693a-4729-90e5-2f155c09c06b"), Type = TextBlockType.Text, Text = "You can (action: Shove) and (action: Trip) even if you don’t have a free hand, provided you are wielding your staff." };
            yield return new TextBlock { Id = Guid.Parse("ade19018-b951-4c08-8cd7-e021dde39982"), Type = TextBlockType.Text, Text = "Finally, when you roll a success on a check to (action: Balance) while wielding your staff, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("37959475-75e9-49db-a94e-82aaa327a162"), requiredStatValue: 16, Stats.Instances.Dexterity.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("3e4a500f-4ff8-474d-9cf9-96e297694d1e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("b9c04e94-c63f-464d-9c25-29ed9159770a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            builder.AddOr(Guid.Parse("3d1a87f5-a25e-43ab-8f03-5c1de4a7b9d7"), or => 
            {
                or.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("fec59a19-51d0-4244-9051-209efc8ac119"), Proficiencies.Instances.Trained.ID, WeaponGroups.Instances.Spear.ID);
                or.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("f860c19e-9b84-4572-a25f-d7171cbca0f5"), Proficiencies.Instances.Trained.ID, WeaponGroups.Instances.Polearm.ID);
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
                Id = Guid.Parse("afec8724-80cf-4510-af31-ee0cf78ad029"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
