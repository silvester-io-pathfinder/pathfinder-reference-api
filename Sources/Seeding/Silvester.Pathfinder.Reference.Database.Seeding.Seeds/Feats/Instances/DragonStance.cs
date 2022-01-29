using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonStance : Template
    {
        public static readonly Guid ID = Guid.Parse("02fe7655-8792-48ad-989f-c2ea21d56623");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Stance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("415002cc-47d8-4e5b-8814-a4f7f7ee52b9"), Type = TextBlockType.Text, Text = $"You enter the stance of a dragon and make powerful leg strikes like a lashing dragon's tail. You can make dragon tail attacks that deal 1d10 bludgeoning damage. They are in the brawling group and have the {ToMarkdownLink<Models.Entities.Trait>("backswing", Traits.Instances.Backswing.ID)}, {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)}, and {ToMarkdownLink<Models.Entities.Trait>("unarmed", Traits.Instances.Unarmed.ID)} traits." };
            yield return new TextBlock { Id = Guid.Parse("86d21fc4-35a7-46e1-bbc3-a16bfdc670d9"), Type = TextBlockType.Text, Text = $"While in Dragon Stance, you can ignore the first square of difficult terrain while {ToMarkdownLink<Models.Entities.Action>("Striding", Actions.Instances.Stride.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ff7fab69-3b0c-49e2-8dac-2d998ac75d54"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Stance.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3bf5b36-134c-4954-9a9c-37b97786a0f6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
