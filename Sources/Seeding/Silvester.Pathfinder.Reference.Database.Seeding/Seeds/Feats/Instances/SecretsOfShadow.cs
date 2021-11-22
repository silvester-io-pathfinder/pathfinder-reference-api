using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SecretsOfShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("ec8f401f-c7ee-4d18-bf59-ef3b6fc67a87");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Secrets of Shadow",
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
            yield return new TextBlock { Id = Guid.Parse("a5326fc0-c84c-431e-9a1c-30041654253f"), Type = TextBlockType.Text, Text = "Your shadow's voice grows ever clearer; it whispers secrets of true power to you and shields your flesh from harm. Your shadow reservoir gains an additional spell 1 level below the highest level spell you can cast, in addition to the spells it already contains for all the levels below that." };
            yield return new TextBlock { Id = Guid.Parse("1ee96602-a70b-469b-9234-9972fd29a0d6"), Type = TextBlockType.Text, Text = "In addition, the tattoos generated by casting shadow spells protect your body against harmful energies. You gain negative resistance equal to the highest level of spell you can cast from spell slots; if you have negative healing (or are otherwise harmed by positive damage and not negative damage), you instead gain positive resistance in the same amount." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c94ac749-5d81-4693-b292-cbdbf88f1606"), Feats.Instances.ShadowReservoir.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("732615f0-bc9f-4290-b771-72a07ccbe9a6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
