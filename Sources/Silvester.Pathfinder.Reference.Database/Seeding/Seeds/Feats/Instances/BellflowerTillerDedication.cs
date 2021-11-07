using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BellflowerTillerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("f6640c56-60c4-4416-a74d-4b26189f860f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bellflower Tiller Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Bellflower tiller archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fff0bfd1-5e1f-4959-b485-e464cb1aa843"), Type = TextBlockType.Text, Text = "You dedicate yourself to freeing slaves and escorting them to freedom. You gain a +5-foot status bonus to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("2ee3194f-975a-4231-bca4-db2773e17b47"), Type = TextBlockType.Text, Text = "Choose up to six other people to be your “crop.” Members of your crop can use your Speed for overland travel if it’s higher than their own. Members more than 60 feet from you lose all benefits (from this or other Bellflower tiller feats) of being part of your crop, but they regain those benefits immediately when they return. You can add or remove someone from your crop by spending 10 minutes in conversation with them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("c76a9b47-e448-470d-8207-8b718d03a18d"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("873cfc89-2841-47f8-bb74-f7047818066b"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("26269fff-e2f5-4529-9d94-fac4fef969c5"), Proficiencies.Instances.Expert.ID, Skills.Instances.Survival.ID);
            builder.Manual(Guid.Parse("f2f36ca6-645a-4e14-a74f-c165fcf6e754"), "Member of the Bellflower Network");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b686039-5deb-4e61-8d2c-f760fbd75c76"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
