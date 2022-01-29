using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SanctifyWater : Template
    {
        public static readonly Guid ID = Guid.Parse("4594cc89-8451-4522-90d4-25b9905fd037");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sanctify Water",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1c987456-9184-4c49-acd9-433c5e13f379"), Type = TextBlockType.Text, Text = $"You imbue water with your deity's blessing. Choose a container of water on your person that is of light Bulk. For 1 round, if you or an ally throw this container at a foe, it has the damaging effects of {ToMarkdownLink<Models.Items.Instances.Consumable>("holy water", Items.Consumables.Instances.HolyWater.ID)} (if you follow a good deity) or {ToMarkdownLink<Models.Items.Instances.Consumable>("unholy water", Items.Consumables.Instances.UnholyWater.ID)} (if you follow an evil deity). The water's transient power doesn't make it gain any value, allow it to be used to supply the cost for a spell or ritual, and so on." };
            yield return new TextBlock { Id = Guid.Parse("e4d21146-5661-4549-a641-3b970cf037f8"), Type = TextBlockType.Text, Text = $"If you have legendary proficiency in Religion, you can sanctify three containers held by you or allies within your reach instead of one." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4109d58e-b3e3-4665-9d50-af90b5350442"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
            builder.AddOr(Guid.Parse("871bb273-b3ca-4075-9740-4b00969bfc7e"), or => 
            {
                or.HaveAnyDeitySpecificAlignment(Guid.Parse("3250d1f3-bcfa-4086-b20a-f0d29f41e79e"), Alignments.Instances.NeutralGood.ID);
                or.HaveAnyDeitySpecificAlignment(Guid.Parse("d9afebea-101f-4bdc-9319-c90589971ae1"), Alignments.Instances.LawfulGood.ID);
                or.HaveAnyDeitySpecificAlignment(Guid.Parse("08e896f2-3ed4-4b7d-8aa5-c898d6e81bd7"), Alignments.Instances.ChaoticGood.ID);
                or.HaveAnyDeitySpecificAlignment(Guid.Parse("d489ffe1-fbec-4376-8746-2f2fef31a39d"), Alignments.Instances.LawfulEvil.ID);
                or.HaveAnyDeitySpecificAlignment(Guid.Parse("f473cbe3-301d-4303-9279-b0f7f6684940"), Alignments.Instances.ChaoticEvil.ID);
                or.HaveAnyDeitySpecificAlignment(Guid.Parse("c6965f38-1fe5-4367-b404-177b5228a750"), Alignments.Instances.NeutralEvil.ID);
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
                Id = Guid.Parse("e080c686-a1ef-4ad7-8f76-b816fc0832a0"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
