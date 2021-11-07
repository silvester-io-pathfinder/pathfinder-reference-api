using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AegisOfArnisant : Template
    {
        public static readonly Guid ID = Guid.Parse("0bdb750f-7671-4e64-8ab0-37ab87a9394e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aegis of Arnisant",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6e9f313e-3603-4491-8048-3a7a8e83454a"), Type = TextBlockType.Text, Text = "Inspired by the tale of Arnisant, you transform your shield into a magic ward. Until the beginning of your next turn, you gain the following reaction:" };
            yield return new TextBlock { Id = Guid.Parse("50c73c7f-893a-4890-9f9d-679c9661014f"), Type = TextBlockType.Text, Text = "~ Absorb into the Aegis: REACTION ((trait: manipulate)) **Trigger** An enemy casts a spell that targets you or an ally within 15 feet of you; **Effect** You interpose your shield’s ward against the spell. Attempt a counteract check, using your Religion modifier as your counteract modifier. On a success, the spell is counteracted and your shield takes damage equal to four times the spell level as it absorbs and disperses the magical energy. On a failure, the shield takes damage equal to twice the spell’s level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("407f8045-546b-4d50-b897-a19f9a7ebd49"), Feats.Instances.KnightVigilantDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("eea7da37-f90f-4fb7-9869-7d5b837997a3"), Feats.Instances.ShieldBlock.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("75fb7a94-7d5b-48ca-ae38-944105f4fa5e"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2305656e-870f-417f-b1c1-45067ea93cc5"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
