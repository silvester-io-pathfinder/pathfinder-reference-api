using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwordmasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("4d4d69df-f903-4d93-b453-9356266a353b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swordmaster Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Swordmaster archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("13dd4961-7691-4abc-b2bd-b3e1ebc540a9"), Type = TextBlockType.Text, Text = $"Your Swords training taught you to never lose hold of your weapon. You gain a +2 circumstance bonus to your Reflex DC when foes attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)} you. If you have the {ToMarkdownLink<Models.Entities.Feat>("Deft Cooperation", Feats.Instances.DeftCooperation.ID)} feat and critically succeed on a check to {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} an ally's attack roll or skill check, you gain a +2 circumstance bonus from {ToMarkdownLink<Models.Entities.Feat>("Deft Cooperation", Feats.Instances.DeftCooperation.ID)} (instead of a +1 bonus) the first time you attempt an attack roll or attempt a skill check where the bonus would apply." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("c45f95bf-a669-4d8f-90fc-afbc436ed0c8"), or => 
            {
                or.HaveSpecificStat(Guid.Parse("68067da5-b6c0-45ff-9eca-55c02ef8b236"), requiredStatValue: 14, Stats.Instances.Strength.ID);
                or.HaveSpecificStat(Guid.Parse("981e8cd9-a6ff-4c12-ad69-c03fbc6bc2c0"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
                or.HaveSpecificStat(Guid.Parse("c900bf65-ed06-4916-8555-1531eb000c8e"), requiredStatValue: 14, Stats.Instances.Constitution.ID);
            });
            builder.Manual(Guid.Parse("43fb26cf-1ee4-4a52-b8db-789c1593200c"), "Member of the Pathfinder Society affiliated with the School of Swords.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("687340ec-15f7-4188-a033-7e5426b610ab"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
