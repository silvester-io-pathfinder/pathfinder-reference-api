using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StaffAcrobatDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("5da694a9-0101-4f82-80e9-7b50ac87a7f6");

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
            yield return new TextBlock { Id = Guid.Parse("47fbab92-51fe-447b-9196-29f089ed2620"), Type = TextBlockType.Text, Text = "When you (action: High Jump), (action: Leap), or (action: Long Jump) while wielding your staff, you gain a +2 circumstance bonus to any Athletics check required and add 5 feet to the distance you can (action: Leap) vertically and horizontally." };
            yield return new TextBlock { Id = Guid.Parse("9ac4da5c-6945-44e1-ad7a-20570086724d"), Type = TextBlockType.Text, Text = "You can (action: Shove) and (action: Trip) even if you don’t have a free hand, provided you are wielding your staff." };
            yield return new TextBlock { Id = Guid.Parse("e6a69f49-e340-444a-8edc-9021b30d035f"), Type = TextBlockType.Text, Text = "Finally, when you roll a success on a check to (action: Balance) while wielding your staff, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("ee3be251-d7a3-4b6b-8de4-4f32987a17a0"), requiredStatValue: 16, Stats.Instances.Dexterity.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("1a9ebbf1-307d-4781-aa4b-1112e666515c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("bb4bf009-a719-4631-954a-b4c6019e16ca"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            builder.AddOr(Guid.Parse("5131f0ab-3e7d-492c-9675-99c50d7b692b"), or => 
            {
                or.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("2c68f4f9-eca2-4254-a3c9-ac0428f00b26"), Proficiencies.Instances.Trained.ID, WeaponGroups.Instances.Spear.ID);
                or.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("78d4b595-3bac-445a-ba33-af92072904f3"), Proficiencies.Instances.Trained.ID, WeaponGroups.Instances.Polearm.ID);
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
                Id = Guid.Parse("eeebd15c-2ac3-4487-bec7-3af716c72fe6"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
